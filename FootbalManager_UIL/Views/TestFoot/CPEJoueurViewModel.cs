using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class CPEJoueurViewModel
    {
        public List<JoueurModel> ListeJoueurVM { get; set; }
        #region constructor par déffaut
        public CPEJoueurViewModel() { }
        #endregion
        #region constructor de class
        public CPEJoueurViewModel(int idContinent, int idPays, int idEquipe)
        {
            ListeJoueurVM = new JoueurModels(idContinent, idPays, idEquipe, -1, 0).ListeJoueurM;
        }
        #endregion
    }
}