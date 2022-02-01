using Balta.ContentContext;

using System.Collections.Generic;

var articles = new List<Article>();
articles.Add(new Article("Artigo sobre OOP", "orientacao-a-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .NET", "dotnet"));

// foreach (var article in articles)
// {
//     Console.WriteLine(article.Id);
//     Console.WriteLine(article.Title);
//     Console.WriteLine(article.Url);
// }

var courses = new List<Course>();
var courseOop = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCsharp = new Course("Fundamentos C#", "fundamentos-oop");
var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-asp-net");

courses.Add(courseOop);
courses.Add(courseCsharp);
courses.Add(courseAspNet);

var careerDotNet = new Career("Especialista .NET", "especialista-net");
var careerItem = new CareerItem(2, "Aprenda OOP", "", null);
var careerItem2 = new CareerItem(1, "Comece por aqui", "", courseCsharp);
var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);

careerDotNet.Items.Add(careerItem);
careerDotNet.Items.Add(careerItem2);
careerDotNet.Items.Add(careerItem3);

var careers = new List<Career>();
careers.Add(careerDotNet);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);

    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title} - Curso: {item.Course?.Title}");

        foreach (var notification in item.Notifications)
        {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
        }
    }
}