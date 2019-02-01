using JoueurFootBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoueurFoot_UIL.Models
{
    #region ContinentModel
    public class ContinentModel
    {
        public int IdM { get; set; }
        public string NomContinentM { get; set; }
    }
    #endregion
    #region ContinentModels : liste des continents
    public class ContinentModels
    {
        public List<ContinentModel> ListeContinent { get; set; }
        private RepoBol repo = new RepoBol();
        public ContinentModels(int idContinent)
        {
            ListeContinent = new List<ContinentModel>();
            var liste = repo.GetContinentDTOs(idContinent);
            foreach (var c in liste)
            {
                ListeContinent.Add(new ContinentModel { IdM = c.IdDto, NomContinentM = c.NomContinentDto });
            }
        }
    }
    #endregion
}