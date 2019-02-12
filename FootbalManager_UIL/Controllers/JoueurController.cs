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
        // GET: Multi Joueurs
        public ActionResult GetJoueur(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            var liste = new ListJoueurViewModel(idContinent, idPays, idEquipe, idPosition, idJoueur);
            return View(liste);
        }
        // Edit: Joueur
        [HttpGet]
        public ActionResult EditJoueur(int idJoueur)
        {
            var joueur = new JoueurViewModel(-1, -1, -1, -1, idJoueur);
            return View(joueur);
        }
        // Detail: Joueur
        [HttpGet]
        public ActionResult DetailsJoueur(int idJoueur)
        {
            var joueur = new JoueurViewModel(-1, -1, -1, -1, idJoueur);
            return View(joueur);
        }
        // Create: Offre
        [HttpGet]
        public ActionResult CreateOffre(int idJoueur, string message)
        {
            var offreVM = new OffreViewModel { IdJoueurVM = idJoueur, Message = message};
            return View(offreVM);
        }
        // Create: Offre
        [HttpPost]
        public ActionResult CreateOffre(OffreViewModel offreVM)
        {
            if (offreVM.CreateOffreViewModel(offreVM))
                return RedirectToAction("CreateTransfer", new { idJoueur = offreVM.IdJoueurVM, prixTransfer = offreVM.PrixOffreVM });
            else
                return RedirectToAction("CreateOffre", new { idJoueur = offreVM.IdJoueurVM, message = "He is not for sale" });
        }
        // Create: Transfer
        [HttpGet]
        public ActionResult CreateTransfer(int idJoueur, int prixTransfer)
        {
            var tranferVM = new TranferViewModel {
                                                FkJoueurVM = idJoueur,
                                                PrixTransferVM = prixTransfer,
                                                PrixSupVM = prixTransfer*2/10 };
            return View(tranferVM);
        }
    }
}