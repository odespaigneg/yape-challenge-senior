using yape_challenge_senior.Models;

namespace yape_challenge_senior.Interfaces
{
    public interface IWhatsAppVendor
    {
        void SendWhatsApp(Notification notification);
    }
}
