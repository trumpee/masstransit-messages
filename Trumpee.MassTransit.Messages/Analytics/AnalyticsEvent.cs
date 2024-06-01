namespace Trumpee.MassTransit.Messages.Analytics;

public class AnalyticsEvent<TBody>
{
    private AnalyticsEvent()
    {
    }

    public TBody? Payload { get; set; }

    public required string StreamId { get; set; }
    public required string Id { get; set; }
    public required string Action { get; set; }
    public required string Version { get; set; }
    public required string Source { get; set; }
    public DateTimeOffset Timestamp { get; set; }
    public Dictionary<string, string>? Metadata { get; set; }

    internal static AnalyticsEvent<T> Create<T>(
        string streamId, string action, string source, T? payload,
        Dictionary<string, string>? metadata = null)
    {
        ArgumentException.ThrowIfNullOrEmpty(streamId);
        ArgumentException.ThrowIfNullOrEmpty(action);
        ArgumentException.ThrowIfNullOrEmpty(source);

        metadata ??= AnalyticsMetadataBuilder.Default;

        var version = metadata[AnalyticsMetadataKeys.EventVersion];

        return new AnalyticsEvent<T>
        {
            Id = Guid.NewGuid().ToString("N"),
            StreamId = streamId,
            Version = version,
            Action = action,
            Source = source,
            Metadata = metadata,
            Timestamp = DateTimeOffset.UtcNow,
            Payload = payload
        };
    }
}
