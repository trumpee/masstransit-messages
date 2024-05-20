namespace Trumpee.MassTransit.Messages;

public class Event<TBody>
{
    public TBody? Payload { get; set; }

    public required string Id { get; set; }
    public required string Action { get; set; }
    public required string Source { get; set; }
    public DateTimeOffset Timestamp { get; set; }
    public Dictionary<string, string>? Metadata { get; set; }
}
