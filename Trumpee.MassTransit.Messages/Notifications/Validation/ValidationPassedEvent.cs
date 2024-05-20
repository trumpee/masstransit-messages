namespace Trumpee.MassTransit.Messages.Notifications.Validation;

public class ValidationPassedEvent : Event<ValidationPassedPayload>
{
    public static ValidationPassedEvent GetEvent(string source, string notificationId)
    {
        return new ValidationPassedEvent
        {
            Id = Guid.NewGuid().ToString("N"),
            Action = nameof(ValidationFailedEvent).ToLower(),
            Source = source,
            Timestamp = DateTimeOffset.UtcNow,
            Metadata = [],
            Payload = new ValidationPassedPayload
            {
                NotificationId = notificationId
            }
        };
    }
}