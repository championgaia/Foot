
using System.Collections.Generic;

namespace JoueurFootDATA
{
    #region PaysData
    internal class PaysData
    {
        public int Id { get; set; }
        public string NomPays { get; set; }
        public int FkContinent { get; set; }
    }
    #endregion
    #region PaysDatas : liste des pays
    internal class PaysDatas
    {
        public List<PaysData> ListePays { get; set; }
        private FootContexte context = new FootContexte();
        public PaysDatas(int idContinent, int idPays)
        {
            ListePays = new List<PaysData>();
            var liste = context.GetPays(idContinent, idPays);
            foreach (var c in liste)
            {
                ListePays.Add(new PaysData { Id = c.Id, NomPays = c.NomPays, FkContinent = c.FkContinent });
            }
        }
    }
    #endregion
}
