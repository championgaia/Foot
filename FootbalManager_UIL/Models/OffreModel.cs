﻿using DTO_UIL_BOL;
using JoueurFootBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL.Models
{
    public class OffreModel
    {
        public int FkContinentM { get; set; }
        public int FkPaysM { get; set; }
        public int FkEquipeM { get; set; }
        public int IdJoueurM { get; set; }
        public double PrixOffreM { get; set; }
        RepoBol repo = new RepoBol();
        #region Faire une offre
        public bool CreateOffreModel(OffreModel offreM)
        {
            return repo.CreateOffreRepoBol(new OffreDTO {
                FkContinentDto = offreM.FkContinentM,
                FkPaysDto = offreM.FkPaysM,
                FkEquipeDto = offreM.FkEquipeM,
                IdJoueurDto = offreM.IdJoueurM,
                PrixOffreDto = offreM.PrixOffreM });
        }
        #endregion
    }
}