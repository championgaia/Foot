using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class ContinentPaysViewModel
    {
        public int FkContinent { get; set; }
        public List<PaysModel> ListePaysVM { get; set; }
        #region Constructeur par déffaut
        public ContinentPaysViewModel(){ }
        #endregion
        #region Liste tous les pays dans un continent
        public ContinentPaysViewModel(int idContinent)
        {
            FkContinent = idContinent;
            ListePaysVM = new PaysModels(idContinent, 0).ListePays;
        }
        #endregion
        #region get un pays
        public ContinentPaysViewModel(int idContinent, int idPays)
        {
            FkContinent = idContinent;
            ListePaysVM = new PaysModels(idContinent, idPays).ListePays;
        }
        #endregion
    }
}