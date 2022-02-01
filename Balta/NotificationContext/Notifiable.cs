namespace Balta.NotificationContext;

public abstract class Notifiable
{
    protected Notifiable() => Notifications = new List<Notification>();

    public List<Notification> Notifications { get; set; }

    public bool IsValid => Notifications.Any() == false;

    public void AddNotification(Notification notification)
        => Notifications.Add(notification);

    public void AddNotifications(IEnumerable<Notification> notifications)
        => Notifications.AddRange(notifications);
}
