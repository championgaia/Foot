using FootbalManager_UIL.Models;
using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class OffreViewModel
    {
        public OffreModel OffreModelVM { get; set; }
        #region Constructeur par déffaut
        public OffreViewModel() { }
        #endregion
        #region Constructeur avec params
        public OffreViewModel(int idContinent, int idPays, int idEquipe, int idJoueur, int idPosition, double prixOffre)
        {
            OffreModelVM = new OffreModel
            {
                IdJoueurM = idJoueur,
                FkContinentM = idContinent,
                FkPaysM = idPays,
                FkEquipeM = idEquipe,
                FkPositionM = idPosition,
                PrixOffreM = prixOffre
            };
        }
        #endregion
        #region Faire une offre
        public bool CreateOffreViewModel(OffreViewModel offreVM)
        {
            return OffreModelVM.CreateOffreModel(offreVM.OffreModelVM);
        }
        #endregion
    }
}