using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Aldrian Bersamina", StudentId = "20-1736", StudentAge = "21" },
            new StudentInfoModel { Name = "Josh Dominguez", StudentId = "20-1754", StudentAge = "22" },
            new StudentInfoModel { Name = "Dennison Daug", StudentId = "20-1767", StudentAge = "31" }
        };

        return View(studentInfoArray);
    }
}
