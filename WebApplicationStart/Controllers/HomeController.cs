using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Tasks()
        {
            return View();
        }

        public string Task1()
        {
            DateTime dateTime = DateTime.Now;
            if (dateTime.Hour >= 0 && dateTime.Hour <= 5)
            { return "ДОБРАЯ НОЧЬ"; }
            if (dateTime.Hour >= 6 && dateTime.Hour <= 11)
            { return "ДОБРОЕ УТРО"; }
            if (dateTime.Hour >= 12 && dateTime.Hour <= 17)
            { return "ДОБРЫЙ ДЕНЬ"; }
            if (dateTime.Hour >= 18 && dateTime.Hour <= 23)
            { return "ДОБРЫЙ ВЕЧЕР"; }
            return "Тут решение первой задачи";
        }
    }
}
