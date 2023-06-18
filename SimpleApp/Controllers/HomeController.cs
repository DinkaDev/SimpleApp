using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string filePath = "~\\wwwroot\\test.txt";
            string fileName = Path.GetFileName(filePath);
            return PhysicalFile(filePath, fileName);
        }
    }
}
