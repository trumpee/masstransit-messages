namespace Trumpee.MassTransit.Messages.Notifications;

public class Content
{
    public required string Subject { get; init; }
    public required string Body { get; init; }

    public Dictionary<string, Variable>? Variables { get; set; }
}