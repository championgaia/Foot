using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class ContinentPaysEquipeViewModel
    {
        public List<EquipeModel> ListeEquipeVM { get; set; }
        #region Constructeur par déffaut
        public ContinentPaysEquipeViewModel() { }
        #endregion
        #region Get tous les equipes dans une pays
        public ContinentPaysEquipeViewModel(int idContinent, int idPays)
        {
            ListeEquipeVM = new EquipeModels(idContinent, idPays, 0).ListeEquipeM;
        }
        #endregion
        #region Get Une Equipe
        public ContinentPaysEquipeViewModel(int idContinent, int idPays, int idEquipe)
        {
            ListeEquipeVM = new EquipeModels(idContinent, idPays, idEquipe).ListeEquipeM;
        }
        #endregion
    }
}