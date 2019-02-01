
using JoueurFootDATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBOL
{
    #region ContinentBOL
    internal class ContinentBOL
    {
        public int Id { get; set; }
        public string NomContinent { get; set; }
    }
    #endregion
    #region ContinentBOLs : liste des continents
    internal class ContinentBOLs
    {
        public List<ContinentBOL> ListeContinent { get; set; }
        private RepoData repo = new RepoData();
        public ContinentBOLs(int idContinent)
        {
            ListeContinent = new List<ContinentBOL>();
            var liste = repo.GetContinentDTOs(idContinent);
            foreach (var c in liste)
            {
                ListeContinent.Add(new ContinentBOL { Id = c.IdDto, NomContinent = c.NomContinentDto });
            }
        }
    }
    #endregion
}

