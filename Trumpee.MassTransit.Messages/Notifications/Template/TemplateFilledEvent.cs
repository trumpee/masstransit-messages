namespace Trumpee.MassTransit.Messages.Notifications.Template;

public class TemplateFilledEvent : Event<TemplateFilledPayload>
{
    public static TemplateFilledEvent GetEvent(
        string source, string templateId, string notificationId)
    {
        return new TemplateFilledEvent
        {
            Id = Guid.NewGuid().ToString("N"),
            Action = nameof(TemplateNotFilledEvent).ToLower(),
            Source = source,
            Timestamp = DateTimeOffset.UtcNow,
            Metadata = [],
            Payload = new TemplateFilledPayload
            {
                TemplateId = templateId,
                NotificationId = notificationId
            }
        };
    }
}
