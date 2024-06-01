using Trumpee.MassTransit.Messages.Analytics.Users.Payloads;

namespace Trumpee.MassTransit.Messages.Analytics.Users;

/// <summary>
/// Provides methods to create user-related analytics events.
/// </summary>
public static class User
{
    /// <summary>
    /// Creates an analytics event indicating that a user has signed up.
    /// </summary>
    /// <param name="source">The source of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="email">The email of the user.</param>
    /// <param name="fullName">The full name of the user.</param>
    /// <param name="commaSeparatedRoles">A comma-separated list of roles assigned to the user.</param>
    /// <returns>An analytics event indicating the user has signed up.</returns>
    public static AnalyticsEvent<UserSignUpPayload> SignUp(
        string source, string userId, string email, string fullName, string commaSeparatedRoles)
    {
        var payload = new UserSignUpPayload
        {
            UserId = userId,
            Email = email,
            Name = fullName,
            Roles = commaSeparatedRoles
        };

        return AnalyticsEvent<UserSignUpPayload>.Create(
            streamId: email,
            action: "UserSignUp",
            source: source,
            payload: payload);
    }

    /// <summary>
    /// Creates an analytics event indicating that a user has signed in.
    /// </summary>
    /// <param name="source">The source of the event.</param>
    /// <param name="email">The email of the user.</param>
    /// <returns>An analytics event indicating the user has signed in.</returns>
    public static AnalyticsEvent<UserSignInPayload> SignIn(
        string source, string email)
    {
        var payload = new UserSignInPayload
        {
            Email = email
        };

        return AnalyticsEvent<UserSignInPayload>.Create(
            streamId: email,
            action: "UserSignIn",
            source: source,
            payload: payload);
    }

    /// <summary>
    /// Creates an analytics event indicating that a user has performed an action.
    /// </summary>
    /// <param name="source">The source of the event.</param>
    /// <param name="email">The email of the user.</param>
    /// <param name="userAction">The action performed by the user.</param>
    /// <param name="usedRole">The role used by the user to perform the action.</param>
    /// <param name="affectedData">The data affected by the user's action.</param>
    /// <returns>An analytics event indicating the user has performed an action.</returns>
    public static AnalyticsEvent<UserActionPayload> Action(
        string source, string email, string userAction, string usedRole, string affectedData)
    {
        var payload = new UserActionPayload
        {
            Email = email,
            UsedRole = usedRole,
            Action = userAction,
            AffectedData = affectedData
        };

        return AnalyticsEvent<UserActionPayload>.Create(
            streamId: email,
            action: "UserAction",
            source: source,
            payload: payload);
    }
}
