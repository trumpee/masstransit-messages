namespace Trumpee.MassTransit.Messages.Analytics.Template.Payloads;

/// <summary>
/// Represents the payload for a template not found event.
/// </summary>
public record TemplateNotFoundPayload
{
    /// <summary>
    /// Gets or sets the ID of the template.
    /// </summary>
    public required string TemplateId { get; init; }

    /// <summary>
    /// Gets or sets the properties associated with the event.
    /// </summary>
    public Dictionary<string, string>? Properties { get; init; }
}
