using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class PaysEquipeViewModel
    {
        public List<PaysModel> ListePaysVM { get; set; }
        public List<EquipeModel> ListeEquipeVM { get; set; }
        public List<JoueurModel> ListeJoueurVM { get; set; }
        #region Constructeur par déffaut
        public PaysEquipeViewModel() { }
        #endregion
        #region Liste tous les pays, equipes, joueurs dans un continent
        public PaysEquipeViewModel(int idContinent)
        {
            ListePaysVM = new PaysModels(idContinent, 0).ListePays;
            ListeEquipeVM = new EquipeModels(idContinent, 0, 0).ListeEquipeM;
            ListeJoueurVM = new JoueurModels(idContinent, 0, 0, -1, 0).ListeJoueurM;
        }
        #endregion
        #region Liste tous les equipes, joueurs dans un pays
        public PaysEquipeViewModel(int idContinent, int idPays)
        {
            ListePaysVM = new PaysModels(idContinent, 0).ListePays;
            ListeEquipeVM = new EquipeModels(idContinent, idPays, 0).ListeEquipeM;
            ListeJoueurVM = new JoueurModels(idContinent, idPays, 0, -1, 0).ListeJoueurM;
        }
        #endregion
        #region Liste tous joueurs dans une equipe
        public PaysEquipeViewModel(int idContinent, int idPays, int idEquipe)
        {
            ListePaysVM = new PaysModels(idContinent, 0).ListePays;
            ListeEquipeVM = new EquipeModels(idContinent, idPays, 0).ListeEquipeM;
            ListeJoueurVM = new JoueurModels(idContinent, idPays, idEquipe, -1, 0).ListeJoueurM;
        }
        #endregion
    }
}