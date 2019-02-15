using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class ListLabelleViewModel
    {
        public string  NomContinent { get; set; }
        public string  NomPays { get; set; }
        public string  NomEquipe { get; set; }
        public string  NomPosition { get; set; }
        public string  NomJoueur { get; set; }
        public ListLabelleViewModel()
        {

        }
        public ListLabelleViewModel(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            ContinentModels continents = new ContinentModels(idContinent);
            PaysModels pays = new PaysModels(idContinent, idPays);
            EquipeModels equipes = new EquipeModels(idContinent, idPays, idEquipe);
            PositionModels positions = new PositionModels(idPosition);
            JoueurModels joueurs = new JoueurModels(idContinent, idPays, idEquipe, idPosition, idJoueur);
            NomContinent = continents.ListeContinent.FirstOrDefault().NomContinentM;
            NomPays = pays.ListePays.FirstOrDefault().NomPaysM;
            NomPosition = positions.ListePosition.FirstOrDefault().NomPositionM;
            NomEquipe = equipes.ListeEquipeM.FirstOrDefault().NomEquipeM;
            NomJoueur = joueurs.ListeJoueurM.FirstOrDefault().NomJoueurM;
        }
    }
}