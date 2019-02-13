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
    }
}