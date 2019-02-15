
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
        // GET: Pays
        public ActionResult GetPays(int idContinent)
        {
            var continentPays = new ContinentPaysViewModel(idContinent);
            return View(continentPays);
        }
        // GET: Equipe
        public ActionResult GetEquipe(int idContinent, int idPays)
        {
            var continentPaysEquipe = new ContinentPaysEquipeViewModel(idContinent, idPays);
            return View(continentPaysEquipe);
        }
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
        // Create: Offre
        [HttpGet]
        public ActionResult CreateOffre(int idContinent, int idPays, int idEquipe, int idJoueur, int idPosition, string message)
        {
            var joueur = new JoueurViewModel(idContinent, idPays, idEquipe, idPosition, idJoueur).Joueur;
            var offreVM = new MakeOffreViewModel
            {
                FkContinentVM = idContinent,
                FkPaysVM = idPays,
                FkEquipeVM = idEquipe,
                IdJoueurVM = idJoueur,
                Message = message,
                FkPositionVM = idPosition,
                NomPositionVM = joueur.PositionM,
                NomEquipeVM = joueur.NomEquipeM,
                NomJoueurVM = joueur.NomJoueurM,
                PreNomJoueurVM = joueur.PrenomM
            };
            return View(offreVM);
        }
        // Create: Offre
        [HttpPost]
        public ActionResult CreateOffre(MakeOffreViewModel makeOffreVM)
        {
            var idContinent = makeOffreVM.FkContinentVM;
            var idPays = makeOffreVM.FkPaysVM;
            var idEquipe = makeOffreVM.FkEquipeVM;
            var idJoueur = makeOffreVM.IdJoueurVM;
            var idPosition = makeOffreVM.FkPositionVM;
            var prixOffre = makeOffreVM.PrixOffreVM;
            var offreVM = new OffreViewModel(idContinent, idPays, idEquipe, idPosition, idJoueur, prixOffre);
            if (offreVM.CreateOffreViewModel(offreVM))
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
                    message = "He is not for sale"
                });
            
        }
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
    }
}