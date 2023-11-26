namespace Trumpee.MassTransit.Messages.Notifications;

public class Notification
{
    public Content? Content { get; set; }
    public Priority? Priority { get; set; }
    public string? Status { get; set; }
    public DateTimeOffset? Timestamp { get; set; }

    public string? UserId { get; set; }
    public string? Channel { get; set; }
}