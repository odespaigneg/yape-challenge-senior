using yape_challenge_senior.Models;
using yape_challenge_senior.Ports;

namespace yape_challenge_senior.Adapters
{
    public class CallNotifier(ICallVendor vendor) : INotifier
    {
        private readonly ICallVendor _vendor = vendor;

        public bool CanHandle(NotificationType type) => type == NotificationType.EMAIL;

        public void Notify(Notification notification)
        {
            _vendor.SendCall(notification);
        }
    }
}
