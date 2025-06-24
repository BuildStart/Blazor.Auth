using BitzArt.Blazor.Auth.Server;

namespace BitzArt.Blazor.Auth.SampleApp.Services;

public class SampleAuthenticationService(JwtService jwtService)
    : AuthenticationService<SignInPayload, SignUpPayload>()
{
    public override Task<AuthenticationResult> SignInAsync(SignInPayload signInPayload, CancellationToken cancellationToken = default)
    {
        //var jwtPair = jwtService.BuildJwtPair();
        var jwtPair = new JwtPair(
            "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhdWQiOiJjb3JldXNlcnNhcGktY2xpZW50cyIsImlzcyI6ImNvcmV1c2Vyc2FwaSIsImV4cCI6MTc1MDc3MzcxMywidXNlcl9ndWlkIjoiOUNENzE1NzktRkYwOC00NjM1LUI0OUQtQzkzQzRENzc3MEIwIiwidmVyc2lvbl9ndWlkIjoiMkNGMUIwQ0EtQzE5NS00ODI3LUI2MUItOUJGNjU4Nzk1N0YxIiwidXNlcm5hbWUiOiJTdGV2ZW4gRCBDb2xsaW5zICIsIm1ldGEiOiJ7XCJmaXJzdF9uYW1lXCI6XCJTdGV2ZW5cIixcImxhc3RfbmFtZVwiOlwiQ29sbGluc1wiLFwidG93blwiOlwiSG9ib2tlblwiLFwicGhvbmVcIjpcIjkxNy03NjMtNDQ0NFwiLFwiYWRkcmVzczFcIjpcIjEyNSBIYXJyaXNvbiBTdFwiLFwiYWRkcmVzczJcIjpcIkFwYXJ0bWVudCA0Q1wifSIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6WyJBZG1pbmlzdHJhdG9yIiwiRWRpdG9yIiwiQXV0aG9yIiwiQ29udHJpYnV0b3IiLCJTdWJzY3JpYmVyIl0sImlhdCI6MTc1MDc3MzY1MywibmJmIjoxNzUwNzczNjUzfQ.cDyY-LEoBhDywxp3-2GxpB9y2IYcdVIqXa0jcrxQFow",
            new DateTime(2025, 6, 24, 14, 1, 53, DateTimeKind.Utc),
            "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhdWQiOiJjb3JldXNlcnNhcGktY2xpZW50cyIsImlzcyI6ImNvcmV1c2Vyc2FwaSIsImV4cCI6MTg0NTM4MTY1MywidXNlcl9ndWlkIjoiOUNENzE1NzktRkYwOC00NjM1LUI0OUQtQzkzQzRENzc3MEIwIiwiaWF0IjoxNzUwNzczNjUzLCJuYmYiOjE3NTA3NzM2NTN9.O_Iijd1zjFfXYA8Pt2sApa6IjqSNnhw30lnD6x0U41g",
            new DateTime(2028, 6, 23, 14, 0, 53, DateTimeKind.Utc)
        );
        var authResult = Success(jwtPair);

        return Task.FromResult(authResult);
    }

    public override Task<AuthenticationResult> RefreshJwtPairAsync(string refreshToken, CancellationToken cancellationToken = default)
    {
        //var jwtPair = jwtService.BuildJwtPair();
        var jwtPair = new JwtPair(
            "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhdWQiOiJjb3JldXNlcnNhcGktY2xpZW50cyIsImlzcyI6ImNvcmV1c2Vyc2FwaSIsImV4cCI6MTc1MDc3MzcxMywidXNlcl9ndWlkIjoiOUNENzE1NzktRkYwOC00NjM1LUI0OUQtQzkzQzRENzc3MEIwIiwidmVyc2lvbl9ndWlkIjoiMkNGMUIwQ0EtQzE5NS00ODI3LUI2MUItOUJGNjU4Nzk1N0YxIiwidXNlcm5hbWUiOiJTdGV2ZW4gRCBDb2xsaW5zICIsIm1ldGEiOiJ7XCJmaXJzdF9uYW1lXCI6XCJTdGV2ZW5cIixcImxhc3RfbmFtZVwiOlwiQ29sbGluc1wiLFwidG93blwiOlwiSG9ib2tlblwiLFwicGhvbmVcIjpcIjkxNy03NjMtNDQ0NFwiLFwiYWRkcmVzczFcIjpcIjEyNSBIYXJyaXNvbiBTdFwiLFwiYWRkcmVzczJcIjpcIkFwYXJ0bWVudCA0Q1wifSIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6WyJBZG1pbmlzdHJhdG9yIiwiRWRpdG9yIiwiQXV0aG9yIiwiQ29udHJpYnV0b3IiLCJTdWJzY3JpYmVyIl0sImlhdCI6MTc1MDc3MzY1MywibmJmIjoxNzUwNzczNjUzfQ.cDyY-LEoBhDywxp3-2GxpB9y2IYcdVIqXa0jcrxQFow",
            new DateTime(2025, 6, 24, 14, 1, 53, DateTimeKind.Utc),
            "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhdWQiOiJjb3JldXNlcnNhcGktY2xpZW50cyIsImlzcyI6ImNvcmV1c2Vyc2FwaSIsImV4cCI6MTg0NTM4MTY1MywidXNlcl9ndWlkIjoiOUNENzE1NzktRkYwOC00NjM1LUI0OUQtQzkzQzRENzc3MEIwIiwiaWF0IjoxNzUwNzczNjUzLCJuYmYiOjE3NTA3NzM2NTN9.O_Iijd1zjFfXYA8Pt2sApa6IjqSNnhw30lnD6x0U41g",
            new DateTime(2028, 6, 23, 14, 0, 53, DateTimeKind.Utc)
        );
        var authResult = Success(jwtPair);

        return Task.FromResult(authResult);
    }

    public override Task<AuthenticationResult> SignUpAsync(SignUpPayload signUpPayload, CancellationToken cancellationToken = default)
    {
        var jwtPair = jwtService.BuildJwtPair();
        var authResult = Success(jwtPair);

        return Task.FromResult(authResult);
    }
}

public class SignUpPayload
{
}