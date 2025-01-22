using System.Text.Json.Serialization;

namespace yape_challenge_senior.Models;

public class Notification : Entity
{
    public Entity Sender { get; set; } = new ();

    public Entity Recipient { get; set; } = new();

    public string Title { get; set; } = string.Empty;

    public string Body { get; set; } = string.Empty;


    [JsonConverter(typeof(JsonStringEnumConverter))]
    public NotificationType Type { get; set; }
}
