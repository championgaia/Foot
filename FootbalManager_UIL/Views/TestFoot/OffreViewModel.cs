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
        public JoueurModel JoueurVM { get; set; }
        public ContinentModel ContinentVM { get; set; }
        public PaysModel PaysVM { get; set; }
        public EquipeModel EquipeVM { get; set; }
        public double PrixOffreVM { get; set; }
        public string Message { get; set; } = "OK";
        #region Faire une offre
        public bool CreateOffreViewModel(OffreViewModel offreVM)
        {
            var offreModel = new OffreModel();
            return offreModel.CreateOffreModel(new OffreModel {
                FkContinentM = offreVM.ContinentVM.IdM,
                FkEquipeM = offreVM.EquipeVM.IdM,
                FkPaysM = offreVM.PaysVM.IdM,
                IdJoueurM = offreVM.JoueurVM.IdM,
                PrixOffreM = offreVM.PrixOffreVM });
        }
        #endregion
    }
}