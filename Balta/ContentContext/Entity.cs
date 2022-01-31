using Balta.NotificationContext;

namespace Balta.ContentContext;

public abstract class Entity : Notifiable
{
    protected Entity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
}
