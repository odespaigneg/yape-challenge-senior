using Moq;
using Xunit;
using yape_challenge_senior.Adapters;
using yape_challenge_senior.Models;
using yape_challenge_senior.Ports;
using yape_challenge_senior.Services;

namespace yape_challenge_senior.Tests
{
    public class NotificationServiceTests
    {
        [Fact]
        public void SendNotification_ShouldInvokeCorrectNotifier()
        {
            // Arrange
            var emailVendorMock = new Mock<IEmailVendor>();
            var emailNotifier = new EmailNotifier(emailVendorMock.Object);
            var notifiers = new List<INotifier> { emailNotifier };

            var notificationService = new NotificationService(notifiers);

            var notification = new Notification
            {
                Sender = new Entity { Resource = "Sender", Fullname = "Sender Name" },
                Recipient = new Entity { Resource = "Recipient", Fullname = "Recipient Name" },
                Title = "Test Title",
                Body = "Test Body",
                Type = NotificationType.EMAIL
            };

            // Act
            notificationService.SendNotification(notification);

            // Assert
            emailVendorMock.Verify(v => v.SendEmail(notification), Times.Once);
        }

        [Fact]
        public void SendNotification_ShouldThrowException_WhenNoNotifierIsFound()
        {
            // Arrange
            var emailVendorMock = new Mock<IEmailVendor>();
            var emailNotifier = new EmailNotifier(emailVendorMock.Object);
            var notifiers = new List<INotifier> { emailNotifier };

            var notificationService = new NotificationService(notifiers);

            var notification = new Notification
            {
                Type = NotificationType.CALL // No notifier for CALL type
            };

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => notificationService.SendNotification(notification));
        }
    }
}
