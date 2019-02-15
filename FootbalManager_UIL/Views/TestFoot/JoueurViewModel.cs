using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class JoueurViewModel
    {
        public JoueurModel Joueur { get; set; }
        #region Constructor par deffaut
        public JoueurViewModel() { }
        #endregion
        #region Constructor
        public JoueurViewModel(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            JoueurModels joueurs = new JoueurModels(idContinent, idPays, idEquipe, idPosition, idJoueur);
            Joueur = joueurs.ListeJoueurM.FirstOrDefault();
        }
        #endregion
    }
}