using Trumpee.MassTransit.Messages.Analytics.Validation.Payloads;

namespace Trumpee.MassTransit.Messages.Analytics.Validation;

/// <summary>
/// Provides methods to create validation-related analytics events.
/// </summary>
public static class Validation
{
    /// <summary>
    /// Creates an analytics event indicating that the validation failed.
    /// </summary>
    /// <param name="source">The source of the event.</param>
    /// <param name="notificationId">The notification ID.</param>
    /// <param name="validationInfoDto">Optional detailed information about the validation.</param>
    /// <returns>An analytics event indicating the validation failed.</returns>
    public static AnalyticsEvent<ValidationFailedPayload> Failed(
        string source, string notificationId, ValidationInfoDto? validationInfoDto = null)
    {
        var payload = new ValidationFailedPayload
        {
            NotificationId = notificationId,
            Explanation = validationInfoDto?.Explanation,
            Offensiveness = validationInfoDto?.Offensiveness,
            OffensiveElements = validationInfoDto?.OffensiveElements,
            SuggestedAlternative = validationInfoDto?.SuggestedAlternative
        };

        return AnalyticsEvent<ValidationFailedPayload>.Create(
            notificationId,
            "ValidationFailed",
            source,
            payload
        );
    }

    /// <summary>
    /// Creates an analytics event indicating that the validation passed.
    /// </summary>
    /// <param name="source">The source of the event.</param>
    /// <param name="notificationId">The notification ID.</param>
    /// <returns>An analytics event indicating the validation passed.</returns>
    public static AnalyticsEvent<ValidationPassedPayload> Passed(string source, string notificationId)
    {
        return AnalyticsEvent<ValidationPassedPayload>.Create(
            notificationId,
            "ValidationPassed",
            source,
            new ValidationPassedPayload
            {
                NotificationId = notificationId,
            });
    }
}
