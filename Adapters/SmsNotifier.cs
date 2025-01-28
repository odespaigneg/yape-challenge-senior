using yape_challenge_senior.Models;
using yape_challenge_senior.Ports;

namespace yape_challenge_senior.Adapters
{
    public class SmsNotifier(ISmsVendor vendor) : INotifier
    {
        private readonly ISmsVendor _vendor = vendor;

        public bool CanHandle(NotificationType type) => type == NotificationType.SMS;

        public void Notify(Notification notification)
        {
            _vendor.SendSms(notification);
        }
    }
}
