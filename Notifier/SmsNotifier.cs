using yape_challenge_senior.Interfaces;
using yape_challenge_senior.Models;

namespace yape_challenge_senior.Notifier;

public class SmsNotifier(ISmsVendor vendor) : INotifier
{
    private readonly ISmsVendor vendor = vendor;

    public bool CanHandle(NotificationType type) => type == NotificationType.SMS;

    public void Notify(Notification notification)
    {
        vendor.SendSms(notification);
    }
}
