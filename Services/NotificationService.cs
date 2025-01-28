using yape_challenge_senior.Models;
using yape_challenge_senior.Ports;

namespace yape_challenge_senior.Services
{
    public class NotificationService
    {
        private readonly IEnumerable<INotifier> _notifiers;

        public NotificationService(IEnumerable<INotifier> notifiers)
        {
            _notifiers = notifiers;
        }

        public void SendNotification(Notification notification)
        {
            var notifier = _notifiers.FirstOrDefault(n => n.CanHandle(notification.Type));

            if (notifier == null)
            {
                throw new InvalidOperationException("No se encontró ningún notificador.");
            }

            notifier.Notify(notification);
        }
    }
}
