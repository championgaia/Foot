using DTO_UIL_BOL;
using JoueurFoot_UIL.Models;
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
        public string NomJoueurM { get; set; }
        public string PreNomJoueurM { get; set; }
        public int FkPositionM { get; set; }
        public string NomPositionM { get; set; }
        public int FkContinentM { get; set; }
        public int FkPaysM { get; set; }
        public int FkEquipeM { get; set; }
        public string NomEquipeM { get; set; }
        public double PrixOffreM { get; set; }
        public string MessageM { get; set; }
        RepoBol repo = new RepoBol();
        #region Faire une offre
        public bool CreateOffreModel(OffreModel offreM)
        {
            return repo.CreateOffreRepoBol(new OffreDTO {
                FkContinentDto = offreM.FkContinentM,
                FkPaysDto = offreM.FkPaysM,
                FkEquipeDto = offreM.FkEquipeM,
                FkPositionDto = offreM.FkPositionM,
                IdJoueurDto = offreM.IdJoueurM,
                PrixOffreDto = offreM.PrixOffreM });
        }
        #endregion
    }
}