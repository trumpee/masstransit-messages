namespace Trumpee.MassTransit.Messages.Analytics.Users.Payloads;

/// <summary>
/// Represents the payload for a user sign-in event.
/// </summary>
public record UserSignInPayload
{
    /// <summary>
    /// Gets or sets the email of the user.
    /// </summary>
    public required string Email { get; init; }
}
