using FootbalManager_UIL.Models;
using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class MakeOffreViewModel
    {
        public OffreModel OffreModelVM { get; set; }
        #region Constructeur par déffaut
        public MakeOffreViewModel() { }
        #endregion
        #region Constructeur avec params
        public MakeOffreViewModel(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur,  double prixOffre, string message)
        {
            var joueur = new JoueurModels(idContinent, idPays, idEquipe, idPosition, idJoueur).ListeJoueurM.FirstOrDefault();
            OffreModelVM = new OffreModel
            {
                IdJoueurM = idJoueur,
                NomJoueurM = joueur.NomJoueurM,
                PreNomJoueurM = joueur.PrenomM,
                FkContinentM = idContinent,
                FkPaysM = idPays,
                FkEquipeM = idEquipe,
                NomEquipeM = joueur.NomEquipeM,
                FkPositionM = idPosition,
                NomPositionM = joueur.PositionM,
                PrixOffreM = prixOffre,
                MessageM = message
            };
        }
        #endregion
        #region Faire une offre
        public bool CreateOffreViewModel(MakeOffreViewModel makeOffreVM)
        {
            return OffreModelVM.CreateOffreModel(makeOffreVM.OffreModelVM);
        }
        #endregion
    }
}