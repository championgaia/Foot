
using JoueurFootDATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBOL
{
    #region PositionBOL
    internal class PositionBOL
    {
        public int Id { get; set; }
        public string NomPosition { get; set; }
    }
    #endregion
    #region ContinentBOLs : liste des continents
    internal class PositionBOLs
    {
        public List<PositionBOL> ListePosition { get; set; }
        private RepoData repo = new RepoData();
        public PositionBOLs(int idPosition)
        {
            ListePosition = new List<PositionBOL>();
            var liste = repo.GetPositionDTOs(idPosition);
            foreach (var c in liste)
            {
                ListePosition.Add(new PositionBOL { Id = c.IdDto, NomPosition = c.NomPositionDTO });
            }
        }
    }
    #endregion
}

