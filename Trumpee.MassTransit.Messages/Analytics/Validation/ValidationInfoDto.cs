namespace Trumpee.MassTransit.Messages.Analytics.Validation;

/// <summary>
/// Represents detailed information about the validation of a notification.
/// </summary>
public class ValidationInfoDto
{
    /// <summary>
    /// Gets or initializes the explanation of the validation.
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
