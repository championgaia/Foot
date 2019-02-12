using FootbalManager_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL.Views.Joueur
{
    public class OffreViewModel
    {
        public int IdJoueurVM { get; set; }
        public int PrixOffreVM { get; set; }
        #region Faire une offre
        public bool CreateOffreModel(OffreViewModel offreVM)
        {
            OffreModel offreModel = new OffreModel();
            return offreModel.CreateOffreModel(new OffreModel { IdJoueurM = offreVM.IdJoueurVM, PrixOffreM = offreVM.PrixOffreVM });
        }
        #endregion
    }
}