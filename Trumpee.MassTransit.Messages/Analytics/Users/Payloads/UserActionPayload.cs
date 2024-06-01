namespace Trumpee.MassTransit.Messages.Analytics.Users.Payloads;

/// <summary>
/// Represents a record of an action performed by a user.
/// </summary>
public record UserActionPayload
{
    /// <summary>
    /// Gets the email of the user who performed the action.
    /// </summary>
    public required string Email { get; init; }

    /// <summary>
    /// Gets the description of the action performed by the user.
    /// </summary>
    public required string Action { get; init; }

    /// <summary>
    /// Gets the role used by the user to perform the action.
    /// </summary>
    public required string UsedRole { get; init; }

    /// <summary>
    /// Gets the data affected by the user's action.
    /// </summary>
    public string? AffectedData { get; init; }
}
