using examenv3.contextModels;
using examenv3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace examenv3.Controllers
{
    public class EmisiuneController : Controller
    {
        private readonly EmisiuneContext context;

        public EmisiuneController(EmisiuneContext context)
        {
            context = context;
        }

        public IActionResult Index()
        {
            var Emisiuni = context.emisiuni.Include(c => c.Canal_TV).ToList();

            return View(Emisiuni);
        }

        public IActionResult GetAdaugareEmisiune()
        {
            ViewBag.canaleTV = context.canale.Select(x => new SelectListItem { Text = x.Nume, Value = x.Id.ToString() }).ToList();
            return View("AdaugaEmisiune");
        }

        [HttpPost]
        public IActionResult PostAdaugareEmisiune(Emisiune emisiune)
        {
            {
                context.Add(emisiune);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult EditeazaEmisiune(int id) //Iii trimitem Id ul stirii ca parametru in url 
        {
            var emisiune = context.emisiuni.Find(id); //Cautam stirea dupa id
            ViewBag.canaleTV = context.canale.Select(x => new SelectListItem { Text = x.Nume, Value = x.Id.ToString() }).ToList(); //populam lista de categorii din formular
            return View(emisiune); //trimitem stirea pe care o modificam catre view
        }
        [HttpPost]
        public IActionResult EditeazaEmisiune(Emisiune emisiune)
        {
            {
                context.emisiuni.Update(emisiune);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult StergeEmisiune(int id) //Iii trimitem Id ul stirii ca parametru in url 
        {
            var emisiune= context.emisiuni.Find(id); //Cautam stirea dupa id
            context.emisiuni.Remove(emisiune);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
