using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class EquipeViewModel
    {
        public EquipeModel EquipeVM { get; set; }
        #region Constructor par deffaut
        public EquipeViewModel() { }
        #endregion
        #region Constructor
        public EquipeViewModel(int idContinent, int idPays, int idEquipe)
        {
            EquipeVM = new EquipeModels(idContinent, idPays, idEquipe).ListeEquipeM.FirstOrDefault();
        }
        #endregion
    }
}