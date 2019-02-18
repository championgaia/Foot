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
        // GET: Continents
        public ActionResult GetContinents()
        {
            return View();
        }
        // GET: Pays by idContinent
        public ActionResult GetPays(int idContinent)
        {
            var listePays = new ContinentPaysViewModel(idContinent);
            return View(listePays);
        }
        // GET: Equipe by IdPays
        public ActionResult GetEquipes(int idContinent, int idPays)
        {
            var listeEquipe = new ContinentPaysEquipeViewModel(idContinent, idPays);
            return View(listeEquipe);
        }
        // GET: Pays, Equipe by IdContinent, IdPays
        public ActionResult GetPaysEquipes(int idContinent, int idPays)
        {
            var listePaysEquipe = new PaysEquipeViewModel(idContinent, idPays);
            return View(listePaysEquipe);
        }
    }
}