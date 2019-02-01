
using System.Collections.Generic;

namespace JoueurFootDATA
{
    #region ContinentData
    internal class ContinentData
    {
        public int Id { get; set; }
        public string NomContinent { get; set; }
    }
    #endregion
    #region ContinentDatas : liste des continents
    internal class ContinentDatas
    {
        public List<ContinentData> ListeContinent { get; set; }
        private FootContexte context = new FootContexte();
        public ContinentDatas(int idContinent)
        {
            ListeContinent = new List<ContinentData>();
            var liste = context.GetContinent(idContinent);
            foreach (var c in liste)
            {
                ListeContinent.Add(new ContinentData { Id = c.Id, NomContinent = c.Nom });
            }
        }
    }
    #endregion
}
