using yape_challenge_senior.Models;

namespace yape_challenge_senior.Interfaces
{
    public interface INotifier
    {
        void Notify(Notification notification);

        bool CanHandle(NotificationType type);
    }
}
