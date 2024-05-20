namespace Trumpee.MassTransit.Messages.Notifications.Template;

public static class Template
{
    public static Event<TemplateFilledPayload> Filled(string source, string notificationId, string templateId)
    {
        var payload = new TemplateFilledPayload
        {
            NotificationId = notificationId,
            TemplateId = templateId
        };

        return Event<TemplateFilledPayload>.Create(
            notificationId, "TemplateFilled", source, payload);
    }

    public static Event<TemplateNotFilledPayload> NotFilled(
        string source, string notificationId, string templateId, IEnumerable<string>? errors)
    {
        var payload = new TemplateNotFilledPayload
        {
            NotificationId = notificationId,
            TemplateId = templateId,
            Errors = errors?.ToList().AsReadOnly()
        };

        return Event<TemplateNotFilledPayload>.Create(
            notificationId, "TemplateNotFilled", source, payload);
    }

    public static Event<TemplateNotFoundPayload> NotFound(
        string source, string notificationId, string templateId, Dictionary<string, string>? props)
    {
        var payload = new TemplateNotFoundPayload
        {
            TemplateId = templateId,
            Properties = props
        };

        return Event<TemplateNotFoundPayload>.Create(
            notificationId, "TemplateNotFound", source, payload);
    }
}
