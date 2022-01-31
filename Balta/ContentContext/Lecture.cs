using Balta.ContentContext.Enums;

namespace Balta.ContentContext;

public class Lecture : Entity
{
    public int Order { get; set; }

    public string Title { get; set; }

    public int DurationInMinutes { get; set; }

    public ContentLevel Level { get; set; }
}
