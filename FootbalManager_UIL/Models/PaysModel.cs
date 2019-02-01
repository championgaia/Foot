using JoueurFootBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoueurFoot_UIL.Models
{
    #region PaysModel
    public class PaysModel
    {
        public int IdM { get; set; }
        public string NomPaysM { get; set; }
    }
    #endregion
    #region PaysModels : liste des Pays
    public class PaysModels
    {
        public List<PaysModel> ListePays { get; set; }
        private RepoBol repo = new RepoBol();
        public PaysModels(int idContinent, int idPays)
        {
            ListePays = new List<PaysModel>();
            var liste = repo.GetPaysDTOs(idContinent, idPays);
            foreach (var c in liste)
            {
                ListePays.Add(new PaysModel { IdM = c.IdDto, NomPaysM = c.NomPaysDto });
            }
        }
    }
    #endregion
}