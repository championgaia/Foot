using JoueurFootBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoueurFoot_UIL.Models
{
    #region PositionModel
    public class PositionModel
    {
        public int IdM { get; set; }
        public string NomPositionM { get; set; }
    }
    #endregion
    #region ContinentModels : liste des continents
    public class PositionModels
    {
        public List<PositionModel> ListePosition { get; set; }
        private RepoBol repo = new RepoBol();
        public PositionModels(int idJoueur)
        {
            ListePosition = new List<PositionModel>();
            var liste = repo.GetPositionDTOs(idJoueur);
            foreach (var c in liste)
            {
                ListePosition.Add(new PositionModel { IdM = c.IdDto, NomPositionM = c.NomPositionDTO });
            }
        }
    }
    #endregion
}