const library = {

  // Class definition.

  $yandexGames: {
    isYandexGames: false,

    sdk: undefined,

    playerAccount: undefined,
    
    billing: undefined,

  allocateUnmanagedString: function (string) {
    const stringBufferSize = lengthBytesUTF8(string) + 1;
    const stringBufferPtr = _malloc(stringBufferSize);
    stringToUTF8(string, stringBufferPtr, stringBufferSize);
    return stringBufferPtr;
  },
  appendBackgroundImage: function (lang) {
    document.head.insertAdjacentHTML("beforeend", `<style>body{background-image: url(Images/background_`+lang+`.png);background-repeat: no-repeat;background-attachment: fixed;background-size: 100% 100%; }</style>`); 
  },
  makeDesktopStyle: function () {
    var container = document.querySelector("#unity-container");
    container.style.userSelect = "none";
    container.addEventListener("contextmenu", (event) => event.preventDefault());
    container.addEventListener("mousedown", (event) => event.preventDefault());
    container.style.display = "flex";
    container.style.justifyContent = "center";
    container.style.alignItems = "center";
    container.style.width = "100%";
    container.style.height = "100%";
    
    var canvas = document.querySelector("#unity-canvas");
    canvas.style.width = "56.25vh";
    canvas.style.height = "100vh";
    canvas.style.maxWidth = "100%";
  },
},
  InitializeYandexGames: function (onSdkInitialize, onPlayerInitialize) {
    const sdkScript = document.createElement('script');
    sdkScript.src = '/sdk.js';
    document.head.appendChild(sdkScript);
    console.log('on sdkScript document.head.append');

    sdkScript.onload = function () {
      console.log('onload sdkScript');
      window['YaGames'].init().then(function (sdk) {
        console.log('on window[YaGames].init()');
        yandexGames.isYandexGames = true;
        yandexGames.sdk = sdk;
        {{{ makeDynCall('v', 'onSdkInitialize') }}}();
        if (sdk.deviceInfo.isDesktop()) {
		  yandexGames.appendBackgroundImage(sdk.environment.i18n.lang);
		  yandexGames.makeDesktopStyle();
        }
        const playerAccountInitializationPromise = sdk.getPlayer().then(function (playerAccount) {
  
          yandexGames.playerAccount = playerAccount;
        }).catch(function () { throw new Error('Player failed to initialize.'); });
  
        const billingInitializationPromise = sdk.getPayments({ signed: false }).then(function (billing) {
          yandexGames.billing = billing;
        }).catch(function () { throw new Error('Billing failed to initialize.'); });


        Promise.allSettled([playerAccountInitializationPromise, billingInitializationPromise]).then(function () {
          console.log('Yandex SDK initialized');
          {{{ makeDynCall('v', 'onPlayerInitialize') }}}();
        });
      }).catch(function (e) {
          console.log('Error on sdk initialization: '+e);
      });
    }
  },

  SaveToYandex: function (data) {
    var dataString = UTF8ToString(data);
    var jsonObject = JSON.parse(dataString);
    yandexGames.playerAccount.setData(jsonObject).catch(function (e) { console.log('Error on saving player data.', e); });
  },
  LoadFromYandex: function (callback) {
    yandexGames.playerAccount.getData().then(_data =>{
        const jsonObject = JSON.stringify(_data);
        console.log('LoadFromYandex jsonObject ' + jsonObject);
        var buffer = yandexGames.allocateUnmanagedString(jsonObject);
        {{{ makeDynCall('vi', 'callback') }}}(buffer);
        _free(buffer);
    }).catch(function (e) { console.log('Error on loading player data. ', e); });
  },
  IsMobile: function () {
    return /iPhone|iPad|iPod|Android/i.test(navigator.userAgent);
  },
  SetToYandexLeaderboard: function (score) {
	if(yandexGames.playerAccount.isAuthorized())
		yandexGames.sdk.leaderboards.setScore('Paint', score);
  },
  GetYandexLanguage: function () {
    return yandexGames.allocateUnmanagedString(yandexGames.sdk.environment.i18n.lang);
  },
  GameReadyToPlayYandex: function () {
    console.log('Game is ready to play');
    yandexGames.sdk.features.LoadingAPI.ready();
  },
  ShowYandexFullscreenAdv: function (onOpen, onClose) {
     yandexGames.sdk.adv.showFullscreenAdv({
        callbacks: {
            onOpen: function() {
            {{{ makeDynCall('v', 'onOpen') }}}();
            },
            onClose: function(wasShown) {
            {{{ makeDynCall('vi', 'onClose') }}}(wasShown);
            },
            onError: function(error) {
              console.log('Error while show FullscreenAdv:', error);
            }
        }
    });
  },
  ShowYandexRewardedVideo: function (onOpen, onRewarded, onClose) {
     yandexGames.sdk.adv.showRewardedVideo({
        callbacks: {
          onOpen: () => {
            {{{ makeDynCall('v', 'onOpen') }}}();
          },
          onRewarded: () => {
            {{{ makeDynCall('v', 'onRewarded') }}}();
          },
          onClose: () => {
            {{{ makeDynCall('v', 'onClose') }}}();
          },
          onError: (e) => {
            console.log('Error while open video ad:', e);
          }
        }
    });
  },
  RequestYandexIsPlayerCanReview: function (response) {
     yandexGames.sdk.feedback.canReview()
        .then(({ value, reason }) => {
            {{{ makeDynCall('vi', 'response') }}}(value);
            if (!value) {
                console.log(reason);
            }
        }); 
  },
  ShowYandexReviewGameWindow: function (onPlayerAction) {
     yandexGames.sdk.feedback.requestReview()
        .then(({ feedbackSent }) => {
            {{{ makeDynCall('vi', 'onPlayerAction') }}}(feedbackSent);
        });
  },
  BillingPurchaseProduct: function (productIdPtr, successCallbackPtr) {
    const productId = UTF8ToString(productIdPtr);

    yandexGames.billing.purchase({ id: productId }).then(function (purchaseResponse) {
      purchaseResponse = { PurchaseData: purchaseResponse.purchaseData, Signature: purchaseResponse.signature };

      const purchasedProductJson = JSON.stringify(purchaseResponse);
      const purchasedProductJsonUnmanagedStringPtr = yandexGames.allocateUnmanagedString(purchasedProductJson);
      {{{ makeDynCall('vi', 'successCallbackPtr') }}}(purchasedProductJsonUnmanagedStringPtr);
      _free(purchasedProductJsonUnmanagedStringPtr);
    }).catch(function (e) {
      console.log('Error while purchasing:', e);
    }).finally(function () {
	  Module.canvas.focus();
    });
  },
  BillingGetProductCatalog: function (successCallbackPtr) {
	yandexGames.billing.getCatalog().then(function (productCatalogResponse) {
      console.log('on yandexGames.billing.getCatalog()');
	  const products = [];

      for (var purchasesIterator = 0; purchasesIterator < productCatalogResponse.length; purchasesIterator++) {
        const product = productCatalogResponse[purchasesIterator];
		console.log('Product in catalog:', product);
		
		products[purchasesIterator] = {
		  Id: product.id,
          PriceCurrencyImage: "https:" + product.getPriceCurrencyImage('medium'),
          PriceValue: product.priceValue,
        };
	  }

      productCatalogResponse = { Products: products	};

      const productCatalogJson = JSON.stringify(productCatalogResponse);
      const productCatalogJsonUnmanagedStringPtr = yandexGames.allocateUnmanagedString(productCatalogJson);
      {{{ makeDynCall('vi', 'successCallbackPtr') }}}(productCatalogJsonUnmanagedStringPtr);
	  _free(productCatalogJsonUnmanagedStringPtr);
    }).catch(function (e) {
      console.log('Error on getting catalog:', e);
    });
  },
  BillingGetPurchasedProducts: function (successCallbackPtr) {
    yandexGames.billing.getPurchases().then(function (purchasesResponse) {
      const purchases = [];

      for (var purchasesIterator = 0; purchasesIterator < purchasesResponse.length; purchasesIterator++) {
        const purchase = purchasesResponse[purchasesIterator];
      	console.log('Purchased product:', purchase);
		
		purchases[purchasesIterator] = {
		  ProductId: purchase.productID,
        };
	  }

	  purchasesResponse = { PurchasedProducts: purchases };

      const purchasedProductsJson = JSON.stringify(purchasesResponse);
      const purchasedProductsJsonUnmanagedStringPtr = yandexGames.allocateUnmanagedString(purchasedProductsJson);
      {{{ makeDynCall('vi', 'successCallbackPtr') }}}(purchasedProductsJsonUnmanagedStringPtr);
      _free(purchasedProductsJsonUnmanagedStringPtr);
    }).catch(function (e) {
      console.log('Error on getting catalog:', e);
    });
  },

  WebDebugLog: function (log) {
    var dataString = UTF8ToString(log);
    console.log(dataString);
  },
}

autoAddDeps(library, '$yandexGames');
mergeInto(LibraryManager.library, library);