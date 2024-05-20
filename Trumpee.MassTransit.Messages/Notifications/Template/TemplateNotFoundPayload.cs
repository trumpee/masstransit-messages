namespace Trumpee.MassTransit.Messages.Notifications.Template;

public class TemplateNotFoundPayload
{
    public required string TemplateId { get; set; }
    public Dictionary<string, string>? Properties { get; set; }
}