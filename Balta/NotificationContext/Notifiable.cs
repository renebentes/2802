namespace Balta.NotificationContext;

public abstract class Notifiable
{
    protected Notifiable() => Notifications = new List<Notification>();

    public List<Notification> Notifications { get; set; }

    public void Add(Notification notification)
        => Notifications.Add(notification);

    public void AddRange(IEnumerable<Notification> notifications)
        => Notifications.AddRange(notifications);
}
