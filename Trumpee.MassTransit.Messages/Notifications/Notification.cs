namespace Trumpee.MassTransit.Messages.Notifications;

public record Notification
{
    public required string NotificationId { get; set; }

    public Content? Content { get; init; }
    public Priority? Priority { get; init; }

    public string? Status { get; init; }

    public DateTimeOffset? Timestamp { get; init; }
    public Recipient Recipient { get; init; } = null!;
}
