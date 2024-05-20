namespace Trumpee.MassTransit.Messages.Notifications.Template;

public class TemplateNotFoundEvent : Event<TemplateNotFoundPayload>
{
    public static TemplateNotFoundEvent GetEvent(string source, string templateId, Dictionary<string, string> props)
    {
        return new TemplateNotFoundEvent
        {
            Id = Guid.NewGuid().ToString("N"),
            Action = nameof(TemplateNotFoundEvent).ToLower(),
            Source = source,
            Timestamp = DateTimeOffset.UtcNow,
            Metadata = [],
            Payload = new TemplateNotFoundPayload
            {
                TemplateId = templateId,
                Properties = props
            }
        };
    }
}
