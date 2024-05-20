namespace Trumpee.MassTransit.Messages.Notifications.Validation;

public static class Validation
{
    public static Event<ValidationFailedPayload> Failed(string source, string notificationId, string error)
    {
        return Event<ValidationFailedPayload>.Create(
            notificationId,
            "ValidationFailed",
            source,
            new ValidationFailedPayload
            {
                NotificationId = notificationId,
                ErrorMessage = error
            });
    }

    public static Event<ValidationPassedPayload> Passed(string source, string notificationId)
    {
        return Event<ValidationPassedPayload>.Create(
            notificationId,
            "ValidationPassed",
            source,
            new ValidationPassedPayload
            {
                NotificationId = notificationId,
            });
    }
}
