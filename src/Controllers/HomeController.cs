using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.EventStorage;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        BuchverwaltungInteraktor interactor;

        public HomeController()
        {
            interactor = new BuchverwaltungInteraktor(new EventStore(),
             new ErzeugeBuchliste(),
             new ErzeugeAngelegtEvent(),
              new ErzeugeBuchLog());
        }
        public IActionResult Index()
        {
            var buecher = interactor.Start();
            var viewModel = buecher.Select(x => new BuchViewModel(x)).ToList();
            return View(viewModel);
        }

        public IActionResult Log()
        {
            var log = new List<BuchLog>();
            log.Add(new BuchLog { Ereignis = "Angelegt", Datum = DateTime.Now, Daten = "Iwas" });
            log.Add(new BuchLog { Ereignis = "Verliehen", Datum = DateTime.Now.AddDays(1), Daten = "Daniel" });
            return Json(log);
        }

        [HttpPost]
        public IActionResult New(string titel)
        {
            //new
            interactor.BuchAnlegen(titel);
            return RedirectToAction("Index");
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
