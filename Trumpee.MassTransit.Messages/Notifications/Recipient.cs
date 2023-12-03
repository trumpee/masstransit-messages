namespace Trumpee.MassTransit.Messages.Notifications;

public record Recipient
{
    public required string UserId { get; init; }
    public required string Channel { get; init; }
    public object? DeliveryInfo { get; init; }
    public Dictionary<string, object>? Metadata { get; init; }
}