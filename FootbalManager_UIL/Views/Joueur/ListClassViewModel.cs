using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class ListClassViewModel
    {
        public ContinentModel Continent { get; set; }
        public PaysModel Pays { get; set; }
        public EquipeModel Equipe { get; set; }
        public PositionModel Position { get; set; }
        public JoueurModel Joueur { get; set; }
        public ListClassViewModel()
        {

        }
        public ListClassViewModel(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            ContinentModels continents = new ContinentModels(idContinent);
            PaysModels pays = new PaysModels(idContinent, idPays);
            EquipeModels equipes = new EquipeModels(idContinent, idPays, idEquipe);
            PositionModels positions = new PositionModels(idPosition);
            JoueurModels joueurs = new JoueurModels(idContinent, idPays, idEquipe, idPosition, idJoueur);
            Continent = continents.ListeContinent.FirstOrDefault();
            Pays = pays.ListePays.FirstOrDefault();
            Position = positions.ListePosition.FirstOrDefault();
            Equipe = equipes.ListeEquipeM.FirstOrDefault();
            Joueur = joueurs.ListeJoueurM.FirstOrDefault();
        }
    }
}