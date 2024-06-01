namespace Trumpee.MassTransit.Messages.Analytics;

public record AnalyticsEvent<TBody>
{
    private AnalyticsEvent()
    {
    }

    public TBody? Payload { get; init; }

    public required string StreamId { get; init; }
    public required string Id { get; init; }
    public required string Action { get; init; }
    public required string Version { get; init; }
    public required string Source { get; init; }
    public DateTimeOffset Timestamp { get; init; }
    public Dictionary<string, string>? Metadata { get; init; }

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
