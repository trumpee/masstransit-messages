namespace Trumpee.MassTransit.Messages.Analytics.Users.Payloads;

/// <summary>
/// Represents the payload for a user created event.
/// </summary>
public record UserSignUpPayload
{
    /// <summary>
    /// Gets or sets the user ID.
    /// </summary>
    public required string UserId { get; init; }

    /// <summary>
    /// Gets or sets the email of the user.
    /// </summary>
    public required string Email { get; init; }

    /// <summary>
    /// Gets or sets the name of the user.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Gets or sets the roles of the user.
    /// Comma separated list of roles.
    /// </summary>
    public required string Roles { get; init; }
}
