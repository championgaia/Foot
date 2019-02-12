using FootbalManager_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class OffreViewModel
    {
        public int IdJoueurVM { get; set; }
        public int PrixOffreVM { get; set; }
        #region Faire une offre
        public bool CreateOffreViewModel(OffreViewModel offreVM)
        {
            return new OffreModel().CreateOffreModel(new OffreModel { IdJoueurM = offreVM.IdJoueurVM, PrixOffreM = offreVM.PrixOffreVM });
        }
        #endregion
    }
}