namespace Trumpee.MassTransit.Messages.Analytics;

/// <summary>
/// Builder class for creating analytics metadata.
/// </summary>
public class AnalyticsMetadataBuilder
{
    private readonly Dictionary<string, string> _metadata = new();

    private AnalyticsMetadataBuilder()
    {
    }

    /// <summary>
    /// Creates a new instance of <see cref="AnalyticsMetadataBuilder"/>.
    /// </summary>
    /// <returns>A new instance of <see cref="AnalyticsMetadataBuilder"/>.</returns>
    public static AnalyticsMetadataBuilder Create()
    {
        return new AnalyticsMetadataBuilder();
    }

    /// <summary>
    /// Adds or overwrites the analytics event version. The default version is v0.
    /// </summary>
    /// <param name="version">The version of the analytics event.</param>
    /// <returns>The current instance of <see cref="AnalyticsMetadataBuilder"/>.</returns>
    public AnalyticsMetadataBuilder AddEventVersion(int version)
    {
        _metadata.Add(AnalyticsMetadataKeys.EventVersion, $"v{version.ToString()}");
        return this;
    }

    /// <summary>
    /// Adds a correlation event stream ID to the metadata.
    /// </summary>
    /// <param name="streamId">The stream ID to correlate events.</param>
    /// <returns>The current instance of <see cref="AnalyticsMetadataBuilder"/>.</returns>
    public AnalyticsMetadataBuilder AddCorrelationEventStreamId(string streamId)
    {
        _metadata.Add(AnalyticsMetadataKeys.CorrelationEventStreamId, streamId);
        return this;
    }

    public Dictionary<string, string> Build()
    {
        return _metadata;
    }

    internal static Dictionary<string, string> Default =>
        new AnalyticsMetadataBuilder()
            .AddEventVersion(0)
            .Build();
}
