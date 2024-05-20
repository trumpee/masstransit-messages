namespace Trumpee.MassTransit.Messages.Notifications.Validation;

public class ValidationFailedEvent : Event<ValidationFailedPayload>
{
    public static ValidationFailedEvent GetEvent(string source, string notificationId, string error)
    {
        return new ValidationFailedEvent
        {
            Id = Guid.NewGuid().ToString("N"),
            Action = nameof(ValidationFailedEvent).ToLower(),
            Source = source,
            Timestamp = DateTimeOffset.UtcNow,
            Metadata = [],
            Payload = new ValidationFailedPayload
            {
                NotificationId = notificationId,
                ErrorMessage = error
            }
        };
    }
}