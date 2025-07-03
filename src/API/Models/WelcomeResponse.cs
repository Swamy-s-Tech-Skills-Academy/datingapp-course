namespace API.Models;

/// <summary>
/// Response model for the welcome endpoint
/// </summary>
public sealed record WelcomeResponse(
    string Message,
    DateTime Timestamp,
    Guid RequestId);
