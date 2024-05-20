namespace Trumpee.MassTransit.Messages;

public class Event<TBody>
{
    private Event()
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

    internal static Event<T> Create<T>(
        string streamId, string action, string source, T? payload,
        Dictionary<string, string>? metadata = null)
    {
        ArgumentException.ThrowIfNullOrEmpty(streamId);
        ArgumentException.ThrowIfNullOrEmpty(action);
        ArgumentException.ThrowIfNullOrEmpty(source);

        var version = "v0";
        if (metadata != null &&
            metadata.TryGetValue("version", out var ver))
        {
            version = ver;
        }

        return new Event<T>
        {
            Version = version,
            StreamId = streamId,
            Id = Guid.NewGuid().ToString("N"),
            Action = action,
            Source = source,
            Metadata = metadata,
            Timestamp = DateTimeOffset.UtcNow,
            Payload = payload
        };
    }
}
