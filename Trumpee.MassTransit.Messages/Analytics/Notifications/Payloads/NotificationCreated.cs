namespace Trumpee.MassTransit.Messages.Analytics.Notifications.Payloads;

/// <summary>
/// Represents the payload for a notification created event.
/// </summary>
public record NotificationCreatedPayload
{
    /// <summary>
    /// Gets or sets the ID of the notification.
    /// </summary>
    public required string NotificationId { get; init; }
}
