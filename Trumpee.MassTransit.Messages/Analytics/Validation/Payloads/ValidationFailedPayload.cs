namespace Trumpee.MassTransit.Messages.Analytics.Validation.Payloads;

/// <summary>
/// Represents the payload for a validation failed event.
/// </summary>
public class ValidationFailedPayload
{
    /// <summary>
    /// Gets or sets the notification ID.
    /// </summary>
    public string? NotificationId { get; set; }

    /// <summary>
    /// Gets or initializes the explanation of the validation failure.
    /// </summary>
    public string? Explanation { get; init; }

    /// <summary>
    /// Gets or initializes the offensiveness rating of the content.
    /// </summary>
    public string? Offensiveness { get; init; }

    /// <summary>
    /// Gets or initializes the suggested alternative content.
    /// </summary>
    public string? SuggestedAlternative { get; init; }

    /// <summary>
    /// Gets or initializes the list of elements in the content that are considered offensive.
    /// </summary>
    public IReadOnlyList<string>? OffensiveElements { get; init; }
}
