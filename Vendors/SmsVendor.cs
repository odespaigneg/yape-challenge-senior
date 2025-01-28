using yape_challenge_senior.Models;
using yape_challenge_senior.Ports;

namespace yape_challenge_senior.Vendors
{
    public class SmsVendor : ISmsVendor
    {
        public void SendSms(Notification notification)
        {
            Console.WriteLine($"Sending SMS from {notification.Sender.Resource} - {notification.Sender.Fullname} to {notification.Recipient.Resource} - {notification.Recipient.Fullname} with title: {notification.Title} and body {notification.Body}");
        }
    }
}
