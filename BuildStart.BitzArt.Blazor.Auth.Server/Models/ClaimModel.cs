using System.Text.Json.Serialization;

namespace BuildStart.BitzArt.Blazor.Auth.Server.Models
{
    public class ClaimModel
    {
        [JsonPropertyName("claim")]
        public string Claim { get; set; } = string.Empty;
    }
}