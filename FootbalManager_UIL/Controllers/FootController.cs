using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootbalManager_UIL.Controllers
{
    public class FootController : Controller
    {
        
        // GET: Foot
        public ActionResult Index()
        {
            return View();
        }
        // GET: Multi Id
        [HttpPost]
        public ActionResult PostId(ListIdViewModel listeId)
        {
            return RedirectToAction("GetId", listeId);
        }
        // Get multi joueur
        public ActionResult GetId(ListIdViewModel listeId)
        { 
            return View(new ListJoueurViewModel(listeId.IdContinent, listeId.IdPays,
                                                listeId.IdEquipe, listeId.IdPosition, listeId.IdJoueur));
        }
    }
}