using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var buecher = new List<Buch>();
            buecher.Add(new Buch { Titel = "Buch 1", VerliehenAm = DateTime.Now.AddDays(-2), VerliehenAn = "Markus" });
            buecher.Add(new Buch { Titel = "Buch 2", VerliehenAm = DateTime.Now.AddDays(-7), VerliehenAn = "Jens" });

            var viewModel = buecher.Select(x => new BuchViewModel(x)).ToList();
            return View(viewModel);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
