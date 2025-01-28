using yape_challenge_senior.Models;

namespace yape_challenge_senior.Ports
{
    public interface ICallVendor
    {
        void SendCall(Notification notification);
    }
}
