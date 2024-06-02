using Trumpee.MassTransit.Messages.Analytics.Notifications.Payloads;

namespace Trumpee.MassTransit.Messages.Analytics.Notifications;

/// <summary>
/// Provides methods to create notification-related analytics events.
/// </summary>
public static class Notification
{
    /// <summary>
    /// Creates an analytics event indicating that a notification has been created.
    /// </summary>
    /// <param name="source">The source of the event.</param>
    /// <param name="notificationId">The ID of the notification.</param>
    /// <returns>An analytics event indicating the notification has been created.</returns>
    public static AnalyticsEvent<NotificationCreatedPayload> Created(
        string source, string notificationId)
    {
        var payload = new NotificationCreatedPayload
        {
            NotificationId = notificationId
        };

        const string actionName = "NotificationCreated";
        return AnalyticsEvent<NotificationCreatedPayload>.Create(
            streamId: notificationId,
            action: actionName,
            source: source,
            payload: payload);
    }

    /// <summary>
    /// Creates an analytics event indicating that a notification has been sent.
    /// </summary>
    /// <param name="source">The source of the event.</param>
    /// <param name="notificationId">The ID of the notification.</param>
    /// <returns>An analytics event indicating the notification has been sent.</returns>
    public static AnalyticsEvent<NotificationSent> Sent(
        string source, string notificationId)
    {
        var payload = new NotificationSent
        {
            NotificationId = notificationId
        };

        const string actionName = "NotificationSent";
        return AnalyticsEvent<NotificationSent>.Create(
            streamId: notificationId,
            action: actionName,
            source: source,
            payload: payload);
    }
}
