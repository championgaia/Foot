using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class ContinentViewModel
    {
        public ContinentModel ContinentVM { get; set; }
        #region constructor par déffaut
        public ContinentViewModel()
        {
            ContinentVM = new ContinentModel();
        }
        #endregion
        #region Constructor avec idContinent
        public ContinentViewModel(int idContinent)
        {
            ContinentVM = new ContinentModels(idContinent).ListeContinent.FirstOrDefault();
        }
        #endregion
    }
}