
using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootbalManager_UIL.Controllers
{
    public class TestFootController : Controller
    {
        // GET: TestFoot
        public ActionResult Index()
        {
            return View();
        }
        #region Pays
        // GET: Pays
        public ActionResult GetPays(int idContinent)
        {
            var continentPays = new ContinentPaysViewModel(idContinent);
            return View(continentPays);
        }
        #endregion
        #region Equipe
        // GET: Equipe
        public ActionResult GetEquipe(int idContinent, int idPays)
        {
            var continentPaysEquipe = new ContinentPaysEquipeViewModel(idContinent, idPays);
            return View(continentPaysEquipe);
        }
        // Edit: Equipe
        [HttpGet]
        public ActionResult EditEquipe(int idContinent, int idPays, int idEquipe)
        {
            var equipe = new EquipeViewModel(idContinent, idPays, idEquipe);
            return View(equipe);
        }
        // Detail: Equipe
        [HttpGet]
        public ActionResult DetailsEquipe(int idContinent, int idPays, int idEquipe)
        {
            var equipe = new EquipeViewModel(idContinent, idPays, idEquipe);
            return View(equipe);
        }
        #endregion
        #region Joueurs
        // GET: Joueurs
        public ActionResult GetJoueur(int idContinent, int idPays, int idEquipe)
        {
            var continentPaysEquipeJoueur = new CPEJoueurViewModel(idContinent, idPays, idEquipe);
            return View(continentPaysEquipeJoueur);
        }
        // Edit: Joueur
        [HttpGet]
        public ActionResult EditJoueur(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            var joueur = new JoueurViewModel(idContinent, idPays, idEquipe, idPosition, idJoueur);
            return View(joueur);
        }
        // Detail: Joueur
        [HttpGet]
        public ActionResult DetailsJoueur(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            var joueur = new JoueurViewModel(idContinent, idPays, idEquipe, idPosition, idJoueur);
            return View(joueur);
        }
        #endregion
        #region Offre
        // Create: Offre
        [HttpGet]
        public ActionResult CreateOffre(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur, string message)
        {
            var offreVM = new MakeOffreViewModel(idContinent, idPays, idEquipe, idPosition, idJoueur, 0, message);
            return View(offreVM);
        }
        // Create: Offre
        [HttpPost]
        public ActionResult CreateOffre(MakeOffreViewModel makeOffreVM)
        {
            var idContinent = makeOffreVM.OffreModelVM.FkContinentM;
            var idPays = makeOffreVM.OffreModelVM.FkPaysM;
            var idEquipe = makeOffreVM.OffreModelVM.FkEquipeM;
            var idJoueur = makeOffreVM.OffreModelVM.IdJoueurM;
            var idPosition = makeOffreVM.OffreModelVM.FkPositionM;
            var prixOffre = makeOffreVM.OffreModelVM.PrixOffreM;
            if (makeOffreVM.CreateOffreViewModel(makeOffreVM))
                return RedirectToAction("CreateTransfer", new
                {
                    idContinent,
                    idPays,
                    idEquipe,
                    idJoueur,
                    prixTransfer = prixOffre
                });
            else
                return RedirectToAction("CreateOffre", new
                {
                    idContinent,
                    idPays,
                    idEquipe,
                    idJoueur,
                    idPosition,
                    message = "He is not for sale"
                });

        }
        #endregion
        #region Transfer
        // Create: Transfer
        [HttpGet]
        public ActionResult CreateTransfer(int idContinent, int idPays, int idEquipe, int idJoueur, int prixTransfer)
        {
            var tranferVM = new TranferViewModel
            {
                JoueurVM = new JoueurViewModel(idContinent, idPays, idEquipe, -1, idJoueur).Joueur,
                OldEquipeVM = new ContinentPaysEquipeViewModel(idContinent, idPays, idEquipe).ListeEquipeVM.FirstOrDefault(),
                PrixTransferVM = prixTransfer,
                PrixSupVM = prixTransfer * 2 / 10
            };
            return View(tranferVM);
        }
        #endregion  
    }
}