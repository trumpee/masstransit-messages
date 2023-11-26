namespace Trumpee.MassTransit.Messages.Notifications;

public class Variable
{
    public required string Name { get; init; }
    public string? Description { get; init; }
    public string? Example { get; init; }
}