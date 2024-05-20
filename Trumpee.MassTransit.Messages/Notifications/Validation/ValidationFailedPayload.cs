namespace Trumpee.MassTransit.Messages.Notifications.Validation;

public class ValidationFailedPayload
{
    public string? NotificationId { get; set; }
    public string? ErrorMessage { get; set; }
}
