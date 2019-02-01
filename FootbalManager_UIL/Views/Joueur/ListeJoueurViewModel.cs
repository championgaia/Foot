using JoueurFoot_UIL.Models;
using System.Collections.Generic;

namespace FootbalManager_UIL
{
    #region ListJoueurViewModel
    public class ListJoueurViewModel
    {
        public List<JoueurModel> ListeJoueur { get; set; }
        public List<ContinentModel> ListeContinent { get; set; }
        public List<PaysModel> ListePays { get; set; }
        public ListJoueurViewModel()
        {

        }
        #region constructor de class
        public ListJoueurViewModel(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            #region ListeJoueur
            ListeJoueur = new List<JoueurModel>();
            JoueurModels joueurs = new JoueurModels(idContinent, idPays, idEquipe, idPosition, idJoueur);
            foreach (var item in joueurs.ListeJoueur)
            {
                ListeJoueur.Add(item);
            }
            #endregion
            #region ListeContinent
            ListeContinent = new List<ContinentModel>();
            ContinentModels continents = new ContinentModels(idContinent);
            foreach (var item in continents.ListeContinent)
            {
                ListeContinent.Add(item);
            }
            #endregion
            #region ListePays
            ListePays = new List<PaysModel>();
            PaysModels pays = new PaysModels(idContinent, idPays);
            foreach (var item in pays.ListePays)
            {
                ListePays.Add(item);
            }
            #endregion
        }
        #endregion
    }
    #endregion
}