using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.ContentContext;

public class CareerItem : Entity
{
    public CareerItem(int order, string title, string description, Course course)
    {
        Order = order;
        Title = title;
        Description = description;
        Course = course;

        if (Course is null)
        {
            AddNotification(new Notification(nameof(Course), "O curso não pode ser nulo"));
        }

    }
    public int Order { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public Course Course { get; set; }
}
