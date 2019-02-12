using DTO_UIL_BOL;
using JoueurFootBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL.Models
{
    public class OffreModel
    {
        public int IdJoueurM { get; set; }
        public double PrixOffreM { get; set; }
        RepoBol repo = new RepoBol();
        #region Faire une offre
        public bool CreateOffreModel(OffreModel offreM)
        {
            return repo.CreateOffreRepoBol(new OffreDTO { IdJoueurDto = offreM.IdJoueurM, PrixOffreDto = offreM.PrixOffreM });
        }
        #endregion
    }
}