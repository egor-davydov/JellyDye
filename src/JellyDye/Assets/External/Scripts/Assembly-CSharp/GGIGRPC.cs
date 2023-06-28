using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using GGI.Analytics;
using GGI.Components;
using GGI.Proto;
using Grpc.Core;
using Polly.CircuitBreaker;

public class GGIGRPC : AutoSingletonMono<GGIGRPC>
{
	private Channel _trackerConnection;

	private Tracker.TrackerClient _trackerClient;

	private string _analyticsUrl;

	private ChannelCredentials _credentials;

	private bool _gameConfigFetched;

	private const int CircuitBreakerThreshold = 3;

	private const int RetryWaitTime = 3;

	private const int CircutBreakerTime = 5;

	private const int gRPCDeadline = 10;

	private AsyncCircuitBreakerPolicy _circuitBreaker;

	private CancellationTokenSource _cancellation;

	private CancellationTokenSource _cancellationAll;

	private List<EventBase> _failedEvents;

	private List<EventBase> _sessionEvents;

	protected override void Awake()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public void InitFromProtocol()
	{
	}

	private void ConnectToTracker()
	{
	}

	public void Send(EventBase ev)
	{
	}

	private Task SendAsync(Event ev)
	{
		return null;
	}

	private Task SendAllAsync(Event[] ev)
	{
		return null;
	}

	private IEnumerator SendRoutine(EventBase ev)
	{
		return null;
	}

	public Task DisconnectFromTracker()
	{
		return null;
	}

	private bool AlreadySent(EventBase ev)
	{
		return false;
	}

	private void AddFailedEvent(EventBase ev)
	{
	}

	private void RemoveFailedEvent(EventBase ev)
	{
	}

	private void SerializeFailedEvents()
	{
	}

	private List<EventBase> LoadFailedEventsFromPreviousSession()
	{
		return null;
	}

	private Event ConvertEvent(EventBase item)
	{
		return null;
	}

	public GGIGRPC()
	{
		((AutoSingletonMono<>)(object)this)._002Ector();
	}
}
