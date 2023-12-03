namespace Trumpee.MassTransit.Messages.Notifications;

public record Content
{
    public required string Subject { get; init; }
    public required string Body { get; init; }

    public Dictionary<string, Variable>? Variables { get; init; }
}