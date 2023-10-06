using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Aldrian Bersamina", StudentId = "20-1736", StudentAge = "21" },
            new StudentInfoModel { Name = "Josh Domiguez", StudentId = "20-1745", StudentAge = "22" },
            new StudentInfoModel { Name = "Mack Sagnoy", StudentId = "20-1756", StudentAge = "31" }
        };

        return View(studentInfoArray);
    }
}
