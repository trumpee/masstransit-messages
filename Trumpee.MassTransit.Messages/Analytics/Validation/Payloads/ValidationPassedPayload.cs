namespace Trumpee.MassTransit.Messages.Analytics.Validation.Payloads;

/// <summary>
/// Represents the payload for a validation passed event.
/// </summary>
public class ValidationPassedPayload
{
    /// <summary>
    /// Gets or sets the notification ID.
    /// </summary>
    public string? NotificationId { get; set; }
}
