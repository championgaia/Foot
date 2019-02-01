using JoueurFootDATA;
using System.Collections.Generic;

namespace ClassBOL
{
    #region PaysBOL
    internal class PaysBOL
    {
        public int Id { get; set; }
        public string NomPays { get; set; }
    }
    #endregion
    #region PaysBOLs : liste des Pays
    internal class PaysBOLs
    {
        public List<PaysBOL> ListePays { get; set; }
        private RepoData repo = new RepoData();
        public PaysBOLs(int idContinent, int idPays)
        {
            ListePays = new List<PaysBOL>();
            var liste = repo.GetPaysDTOs(idContinent, idPays);
            foreach (var c in liste)
            {
                ListePays.Add(new PaysBOL { Id = c.IdDto, NomPays = c.NomPaysDto });
            }
        }
    }
    #endregion
}
