using yape_challenge_senior.Interfaces;
using yape_challenge_senior.Models;

namespace yape_challenge_senior.Notifier
{
    public class CallNotifier(ICallVendor vendor) : INotifier
    {
        private readonly ICallVendor vendor = vendor;

        public bool CanHandle(NotificationType type) => type == NotificationType.EMAIL;

        public void Notify(Notification notification)
        {
            vendor.SendCall(notification);
        }
    }
}
