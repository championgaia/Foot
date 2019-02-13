using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class ContinentPaysEquipeViewModel
    {
        public int FkContinent { get; set; }
        public int FkPays { get; set; }
        public List<EquipeModel> ListeEquipeVM { get; set; }
        #region Constructeur par déffaut
        public ContinentPaysEquipeViewModel() { }
        #endregion
        #region MyRegion
        public ContinentPaysEquipeViewModel(int idContinent, int idPays)
        {
            FkContinent = idContinent;
            FkPays = idPays;
            ListeEquipeVM = new EquipeModels(idContinent, idPays, 0).ListeEquipe;
        }
        #endregion
    }
}