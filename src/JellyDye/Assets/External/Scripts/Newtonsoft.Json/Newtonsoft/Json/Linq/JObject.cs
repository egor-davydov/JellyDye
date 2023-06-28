using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor
	{
		private class JObjectDynamicProxy : DynamicProxy<JObject>
		{
			public override IEnumerable<string> GetDynamicMemberNames(JObject instance)
			{
				return null;
			}

			public JObjectDynamicProxy()
			{
				((DynamicProxy<>)(object)this)._002Ector();
			}
		}

		private readonly JPropertyKeyedCollection _properties;

		[CompilerGenerated]
		private PropertyChangingEventHandler PropertyChanging;

		protected override IList<JToken> ChildrenTokens => null;

		public override JTokenType Type => default(JTokenType);

		public JToken Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private ICollection<string> System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EKeys => null;

		private ICollection<JToken> System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EValues => null;

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EIsReadOnly => false;

		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public JObject()
		{
		}

		public JObject(JObject other)
		{
		}

		public JObject(params object[] content)
		{
		}

		public JObject(object content)
		{
		}

		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		internal override bool InsertItem(int index, JToken item, bool skipParentCheck)
		{
			return false;
		}

		internal override void ValidateToken(JToken o, JToken existing)
		{
		}

		internal void InternalPropertyChanged(JProperty childProperty)
		{
		}

		internal void InternalPropertyChanging(JProperty childProperty)
		{
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public IEnumerable<JProperty> Properties()
		{
			return null;
		}

		public JProperty Property(string name, StringComparison comparison)
		{
			return null;
		}

		public static JObject Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		public void Add(string propertyName, JToken value)
		{
		}

		public bool ContainsKey(string propertyName)
		{
			return false;
		}

		public bool Remove(string propertyName)
		{
			return false;
		}

		public bool TryGetValue(string propertyName, out JToken value)
		{
			value = null;
			return false;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EAdd(KeyValuePair<string, JToken> item)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EClear()
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EContains(KeyValuePair<string, JToken> item)
		{
			return false;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ECopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ERemove(KeyValuePair<string, JToken> item)
		{
			return false;
		}

		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			return null;
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		protected virtual void OnPropertyChanging(string propertyName)
		{
		}

		private PropertyDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetProperties()
		{
			return null;
		}

		private PropertyDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetProperties(Attribute[] attributes)
		{
			return null;
		}

		private AttributeCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetAttributes()
		{
			return null;
		}

		private TypeConverter System_002EComponentModel_002EICustomTypeDescriptor_002EGetConverter()
		{
			return null;
		}

		private object System_002EComponentModel_002EICustomTypeDescriptor_002EGetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}

		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}
	}
}
