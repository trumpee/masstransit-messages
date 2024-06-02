namespace Trumpee.MassTransit.Messages.Analytics.Notifications.Payloads;

/// <summary>
/// Represents the payload for a notification sent event.
/// </summary>
public class NotificationSent
{
    /// <summary>
    /// Gets or sets the ID of the notification.
    /// </summary>
    public required string NotificationId { get; set; }
}
