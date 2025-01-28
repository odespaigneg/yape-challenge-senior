using yape_challenge_senior.Models;
using yape_challenge_senior.Ports;

namespace yape_challenge_senior.Adapters
{
    public class EmailNotifier(IEmailVendor vendor) : INotifier
    {
        private readonly IEmailVendor _vendor = vendor;

        public bool CanHandle(NotificationType type) => type == NotificationType.EMAIL;

        public void Notify(Notification notification)
        {
            _vendor.SendEmail(notification);
        }
    }
}
