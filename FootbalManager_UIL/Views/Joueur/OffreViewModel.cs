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
        public double PrixOffreVM { get; set; }
        public string Message { get; set; } = "OK";
        #region Faire une offre
        public bool CreateOffreViewModel(OffreViewModel offreVM)
        {
            var offreModel = new OffreModel();
            return offreModel.CreateOffreModel(new OffreModel { IdJoueurM = offreVM.IdJoueurVM, PrixOffreM = offreVM.PrixOffreVM });
        }
        #endregion
    }
}