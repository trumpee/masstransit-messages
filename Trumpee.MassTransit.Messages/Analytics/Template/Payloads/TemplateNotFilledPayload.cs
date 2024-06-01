namespace Trumpee.MassTransit.Messages.Analytics.Template.Payloads;

/// <summary>
/// Represents the payload for a template not filled event.
/// </summary>
public record TemplateNotFilledPayload
{
    /// <summary>
    /// Gets or sets the ID of the template.
    /// </summary>
    public required string TemplateId { get; init; }

    /// <summary>
    /// Gets or sets the ID of the notification.
    /// </summary>
    public required string NotificationId { get; init; }

    /// <summary>
    /// Gets or sets the list of errors that occurred.
    /// </summary>
    public IReadOnlyList<string>? Errors { get; init; }
}
