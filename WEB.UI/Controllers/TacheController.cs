using AM.ApplicationCore.Interfaces;
using ApplicationCore.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEB.UI.Controllers
{
    public class TacheController : Controller
    {
        readonly IService<Tache> TacheService;
        public TacheController(IService<Tache> TacheService)
        {
            this.TacheService = TacheService;
        }

        // GET: TacheController
        public ActionResult Index()
        {
            return View(TacheService.GetAll().Where(h => h.etatTache == EtatTache.OUVERTE).OrderBy(h => h.Titre));
        }

        // GET: TacheController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult dina(string id)
        {
            return View(TacheService.GetAll().Where
                (dina=>dina.MembreKey==id).Select(hh=>hh.Menmbre).First());
        }

        // GET: TacheController/Create
        public ActionResult Create()
        {
            var dina = TacheService.GetAll();
            ViewBag.e = new SelectList(dina, "etatTache", "etatTache");
            ViewBag.s = new SelectList(dina, "SprintKey", "SprintKey");
            ViewBag.m = new SelectList(dina, "MembreKey", "MembreKey");
            return View();

           
        }

        // POST: TacheController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Tache dina)
        {
            try
            {
                TacheService.Add(dina);
                TacheService.Commit();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TacheController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TacheController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TacheController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TacheController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
