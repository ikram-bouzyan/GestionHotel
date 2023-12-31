using GestionHotel.Models;
using Microsoft.AspNetCore.Mvc;
using GestionHotel.Data;
namespace GestionHotel.Controllers
{
    public class ChambreController : Controller
    {
        public static List<Chambre> Chambres = ChambreList.GetChambres();
        public static List<Chambre> DeletedChambres = new List<Chambre>();  // New list for deleted Chambres
        private static List<Chambre> ChambresEtage2 = new List<Chambre>();

        public IActionResult Index()
        {
            ViewBag.Chambres = Chambres;
            return View();
        }

        [HttpGet]
        public IActionResult Ajouter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ajouter(Chambre ch)
        {
            Chambres.Add(ch);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Modifier()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Modifier(Chambre ch)
        {
            Chambre Ch = Chambres.Find(chambre => chambre.Numero == ch.Numero);
            Ch.Type = ch.Type;
            Ch.NumeroEtage = ch.NumeroEtage;
            Ch.DateDebut = ch.DateDebut;
            Ch.DateFin = ch.DateFin;

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Supprimer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Supprimer(int numero)
        {
            var chambre = Chambres.Find(ch => ch.Numero == numero);

            if (chambre == null)
            {
                return NotFound();
            }
            Chambres.Remove(chambre);
            return RedirectToAction("Index");
        }

        public IActionResult Afficher()
        {
            //    if (Chambres.Count() != null)
            //    {
            //        for (int i = 0; i < Chambres.Count(); i++)
            //        {
            //            if (Chambres[i].NumeroEtage == 2)
            //            {
            //                ChambresEtage2.Add(Chambres[i]);
            //            }
            //        }
            //        ViewBag.Chambres2EmeEtage = ChambresEtage2;
            //        return View();
            //    }
            //    else
            //    {
            //        return RedirectToAction("Index");
            //    }

            //}
           ViewBag.Chambres2EmeEtage = Chambres.FindAll(ch => ch.NumeroEtage == 2);
           return View();
        }
    }
}
