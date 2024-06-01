namespace Trumpee.MassTransit.Messages.Analytics;

/// <summary>
/// Contains keys used for analytics metadata.
/// </summary>
public static class AnalyticsMetadataKeys
{
    /// <summary>
    /// The key for the event version.
    /// </summary>
    public const string EventVersion = "version";

    /// <summary>
    /// The key for the correlation event stream ID.
    /// </summary>
    public const string CorrelationEventStreamId = "correlation-stream-id";
}

