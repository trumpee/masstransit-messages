namespace Trumpee.MassTransit.Messages.Notifications.Template;

public class TemplateNotFilledEvent : Event<TemplateNotFilledPayload>
{
    public static TemplateNotFilledEvent GetEvent(
        string source, string templateId, string notificationId)
    {
        return new TemplateNotFilledEvent
        {
            Id = Guid.NewGuid().ToString("N"),
            Action = nameof(TemplateNotFilledEvent).ToLower(),
            Source = source,
            Timestamp = DateTimeOffset.UtcNow,
            Metadata = [],
            Payload = new TemplateNotFilledPayload
            {
                TemplateId = templateId,
                NotificationId = notificationId
            }
        };
    }
}
