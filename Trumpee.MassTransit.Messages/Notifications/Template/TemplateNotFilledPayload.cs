namespace Trumpee.MassTransit.Messages.Notifications.Template;

public class TemplateNotFilledPayload
{
    public required string TemplateId { get; set; }
    public required string NotificationId { get; set; }
    public IReadOnlyList<string>? Errors { get; set; }
}
