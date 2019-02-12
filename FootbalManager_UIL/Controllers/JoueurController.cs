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
            ListJoueurViewModel liste = new ListJoueurViewModel(0, 0, 0, 0, 0);
            return View(liste);
        }
        // GET: Multi Id
        public ActionResult GetId(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            ListIdViewModel listeId = new ListIdViewModel(idContinent, idPays, idEquipe, idPosition, idJoueur);
            return View(listeId);
        }
        // GET: Multi Joueurs
        public ActionResult GetJoueur(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            ListJoueurViewModel liste = new ListJoueurViewModel(idContinent, idPays, idEquipe, idPosition, idJoueur);
            return View(liste);
        }
        // Edit: Joueur
        [HttpGet]
        public ActionResult EditJoueur(int idJoueur)
        {
            JoueurViewModel joueur = new JoueurViewModel(-1, -1, -1, -1, idJoueur);
            return View(joueur);
        }
        // Detail: Joueur
        [HttpGet]
        public ActionResult DetailsJoueur(int idJoueur)
        {
            JoueurViewModel joueur = new JoueurViewModel(-1, -1, -1, -1, idJoueur);
            return View(joueur);
        }
        // Create: Offre
        [HttpGet]
        public ActionResult CreateOffre(int idJoueur)
        {
            OffreViewModel offreVM = new OffreViewModel { IdJoueurVM = idJoueur};
            return View(offreVM);
        }
        // Create: Offre
        [HttpPost]
        public ActionResult CreateOffre(OffreViewModel offreVM)
        {
            if (!offreVM.CreateOffreViewModel(offreVM))
                return RedirectToAction("CreateOffre", new { idJoueur = offreVM.IdJoueurVM });
            else
                return RedirectToAction("Index");
        }

    }
}