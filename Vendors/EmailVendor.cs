using yape_challenge_senior.Models;
using yape_challenge_senior.Ports;

namespace yape_challenge_senior.Vendors
{
    public class EmailVendor : IEmailVendor
    {
        public void SendEmail(Notification notification)
        {
            Console.WriteLine($"Sending Email from {notification.Sender.Resource} to {notification.Recipient.Fullname} with title: {notification.Title} and body: {notification.Body}");
        }
    }
}
