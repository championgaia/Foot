using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class ListObjetViewModel
    {
        public int IdContinent { get; set; } = -1;
        public int IdPays { get; set; } = -1;
        public int IdEquipe { get; set; } = -1;
        public int IdPosition { get; set; } = -1;
        public int IdJoueur { get; set; } = -1;
        public string  NomContinent { get; set; }
        public string  NomPays { get; set; }
        public string  NomEquipe { get; set; }
        public string  NomPosition { get; set; }
        public string  NomJoueur { get; set; }
        public ListObjetViewModel()
        {

        }
        public ListObjetViewModel(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            ContinentModels continents = new ContinentModels(idContinent);
            PaysModels pays = new PaysModels(idContinent, idPays);
            EquipeModels equipes = new EquipeModels(idContinent, idPays, idEquipe);
            PositionModels positions = new PositionModels(idPosition);
            JoueurModels joueurs = new JoueurModels(idContinent, idPays, idEquipe, idPosition, idJoueur);
            IdContinent = idContinent;
            IdPays = idPays;
            IdEquipe = idEquipe;
            IdPosition = idPosition;
            IdJoueur = idJoueur;
            NomContinent = continents.ListeContinent.FirstOrDefault().NomContinentM;
            NomPays = pays.ListePays.FirstOrDefault().NomPaysM;
            NomPosition = positions.ListePosition.FirstOrDefault().NomPositionM;
            NomEquipe = equipes.ListeEquipe.FirstOrDefault().NomEquipeM;
            NomJoueur = joueurs.ListeJoueurM.FirstOrDefault().NomJoueurM;
        }
    }
}