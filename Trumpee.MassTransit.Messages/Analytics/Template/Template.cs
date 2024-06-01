using Trumpee.MassTransit.Messages.Analytics.Template.Payloads;

namespace Trumpee.MassTransit.Messages.Analytics.Template;

/// <summary>
/// Provides methods to create template-related analytics events.
/// </summary>
public static class Template
{
    /// <summary>
    /// Creates an analytics event indicating that the template was filled successfully.
    /// </summary>
    /// <param name="source">The source of the event.</param>
    /// <param name="notificationId">The notification ID.</param>
    /// <param name="templateId">The template ID.</param>
    /// <returns>An analytics event indicating the template was filled.</returns>
    public static AnalyticsEvent<TemplateFilledPayload> Filled(string source, string notificationId, string templateId)
    {
        var payload = new TemplateFilledPayload
        {
            NotificationId = notificationId,
            TemplateId = templateId
        };

        return AnalyticsEvent<TemplateFilledPayload>.Create(
            notificationId, "TemplateFilled", source, payload);
    }

    /// <summary>
    /// Creates an analytics event indicating that the template was not filled due to errors.
    /// </summary>
    /// <param name="source">The source of the event.</param>
    /// <param name="notificationId">The notification ID.</param>
    /// <param name="templateId">The template ID.</param>
    /// <param name="errors">The list of errors that occurred.</param>
    /// <returns>An analytics event indicating the template was not filled.</returns>
    public static AnalyticsEvent<TemplateNotFilledPayload> NotFilled(
        string source, string notificationId, string templateId, IEnumerable<string>? errors)
    {
        var payload = new TemplateNotFilledPayload
        {
            NotificationId = notificationId,
            TemplateId = templateId,
            Errors = errors?.ToList().AsReadOnly()
        };

        return AnalyticsEvent<TemplateNotFilledPayload>.Create(
            notificationId, "TemplateNotFilled", source, payload);
    }

    /// <summary>
    /// Creates an analytics event indicating that the template was not found.
    /// </summary>
    /// <param name="source">The source of the event.</param>
    /// <param name="notificationId">The notification ID.</param>
    /// <param name="templateId">The template ID.</param>
    /// <param name="props">The properties associated with the event.</param>
    /// <returns>An analytics event indicating the template was not found.</returns>
    public static AnalyticsEvent<TemplateNotFoundPayload> NotFound(
        string source, string notificationId, string templateId, Dictionary<string, string>? props)
    {
        var payload = new TemplateNotFoundPayload
        {
            TemplateId = templateId,
            Properties = props
        };

        return AnalyticsEvent<TemplateNotFoundPayload>.Create(
            notificationId, "TemplateNotFound", source, payload);
    }
}
