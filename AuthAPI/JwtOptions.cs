namespace AuthAPI;

public class JwtOptions
{
    public const string Jwt = "Jwt";

    public string SigningKey { get; set; } = null!;
}