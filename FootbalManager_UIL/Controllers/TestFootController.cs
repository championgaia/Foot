
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
        public ActionResult EditJoueur(int idContinent, int idPays, int idEquipe, int idJoueur)
        {
            var position = new PositionModels(idJoueur).ListePosition.FirstOrDefault();
            var joueur = new JoueurViewModel(idContinent, idPays, idEquipe, position.IdM, idJoueur);
            return View(joueur);
        }
        // Detail: Joueur
        [HttpGet]
        public ActionResult DetailsJoueur(int idContinent, int idPays, int idEquipe, int idJoueur)
        {
            var position = new PositionModels(idJoueur).ListePosition.FirstOrDefault();
            var joueur = new JoueurViewModel(idContinent, idPays, idEquipe, position.IdM, idJoueur);
            return View(joueur);
        }
        // Create: Offre
        [HttpGet]
        public ActionResult CreateOffre(int idContinent, int idPays, int idEquipe, int idJoueur, string message)
        {
            var position = new PositionModels(idJoueur).ListePosition.FirstOrDefault();
            var joueur = new JoueurViewModel(idContinent, idPays, idEquipe, position.IdM, idJoueur).Joueur;
            var equipe = new ContinentPaysEquipeViewModel(idContinent, idPays, idEquipe).ListeEquipeVM.FirstOrDefault();
            var offreVM = new MakeOffreViewModel
            {
                FkContinentVM = idContinent,
                FkPaysVM = idPays,
                FkEquipeVM = idEquipe,
                IdJoueurVM = idJoueur,
                Message = message,
                FkPositionVM = position.IdM,
                NomPositionVM = position.NomPositionM,
                NomEquipeVM = equipe.NomEquipeM,
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
            var offreVM = new OffreViewModel
            {
                JoueurVM = new JoueurViewModel(idContinent, idPays, idEquipe, idPosition, idJoueur).Joueur,
                EquipeVM = new ContinentPaysEquipeViewModel(idContinent, idPays, idEquipe).ListeEquipeVM.FirstOrDefault(),
                ContinentVM = new ContinentViewModel(idContinent).ContinentVM,
                PaysVM = new ContinentPaysViewModel(idContinent, idPays).ListePaysVM.FirstOrDefault(),
                PrixOffreVM = makeOffreVM.PrixOffreVM,
                Message = makeOffreVM.Message
            };
            if (offreVM.CreateOffreViewModel(offreVM))
                return RedirectToAction("CreateTransfer", new
                {
                    idContinent = offreVM.ContinentVM.IdM,
                    idPays = offreVM.PaysVM.IdM,
                    idEquipe = offreVM.EquipeVM.IdM,
                    idJoueur = offreVM.JoueurVM.IdM,
                    prixTransfer = offreVM.PrixOffreVM
                });
            else
                return RedirectToAction("CreateOffre", new
                {
                    idContinent = offreVM.ContinentVM.IdM,
                    idPays = offreVM.PaysVM.IdM,
                    idEquipe = offreVM.EquipeVM.IdM,
                    idJoueur = offreVM.JoueurVM.IdM,
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