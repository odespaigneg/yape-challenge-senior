using yape_challenge_senior.Models;

namespace yape_challenge_senior.Ports
{
    public interface IWhatsAppVendor
    {
        void SendWhatsApp(Notification notification);
    }
}
