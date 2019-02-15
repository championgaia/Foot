using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootbalManager_UIL.Controllers
{
    public class JoueurController : Controller
    {
        // GET: AllJoueur
        public ActionResult Index()
        {
            var liste = new ListJoueurViewModel(0, 0, 0, 0, 0);
            return View(liste);
        }
        // GET: Multi Id
        public ActionResult GetId(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            var listeId = new ListIdViewModel(idContinent, idPays, idEquipe, idPosition, idJoueur);
            return View(listeId);
        }

    }
}