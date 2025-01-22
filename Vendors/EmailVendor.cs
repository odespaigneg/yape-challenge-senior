using yape_challenge_senior.Interfaces;
using yape_challenge_senior.Models;

namespace yape_challenge_senior.Vendors;

public class EmailVendor : IEmailVendor
{
    public void SendEmail(Notification notification)
    {
        Console.WriteLine(String.Format(
            "Sending Email from {0} - {1} to {2} - {3} with title: {4} and body {5}", 
            notification.Sender.Resource, 
            notification.Sender.Fullname, 
            notification.Recipient.Resource, 
            notification.Recipient.Fullname, 
            notification.Title, 
            notification.Body
        ));    
    }
}
