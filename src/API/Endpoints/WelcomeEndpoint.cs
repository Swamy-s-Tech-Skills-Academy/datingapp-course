namespace API.Endpoints;

/// <summary>
/// Response model for the welcome endpoint
/// </summary>
public sealed record WelcomeResponse(
    string Message,
    DateTime Timestamp,
    Guid RequestId);

/// <summary>
/// Welcome endpoint for the Dating App API
/// </summary>
public static class WelcomeEndpoint
{
    /// <summary>
    /// Maps the welcome endpoint
    /// </summary>
    /// <param name="app">The web application</param>
    /// <returns>The configured web application</returns>
    public static IEndpointRouteBuilder MapWelcomeEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", GetWelcomeMessage)
        .WithName("GetWelcome")
        .WithTags("General")
        .WithSummary("Get welcome message")
        .WithDescription("Returns a welcome message with current timestamp and unique request ID")
        .WithOpenApi()
        .Produces<WelcomeResponse>(StatusCodes.Status200OK);

        return app;
    }

    /// <summary>
    /// Handles the welcome endpoint request
    /// </summary>
    /// <returns>Welcome response with message, timestamp and request ID</returns>
    private static IResult GetWelcomeMessage()
    {
        var response = new WelcomeResponse(
            Message: "Welcome to Dating App API",
            Timestamp: DateTime.UtcNow,
            RequestId: Guid.NewGuid());

        return TypedResults.Ok(response);
    }
}
