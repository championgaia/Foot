using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoueurFootDATA
{
    #region ContinentSingletonData
    internal class ContinentSingletonData
    {
        public int Id { get; set; }
        public string NomContinent { get; set; }
        static ContinentSingletonData instance = null;
        #region constructor par déffaut privé
        ContinentSingletonData() { }
        #endregion
        #region gestion d'instanciation
        public static ContinentSingletonData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContinentSingletonData();
                }
                return instance;
            }
        }
        #endregion
    }
    #endregion
    #region ContinentDatas : liste des continents
    internal class ContinentSingletonDatas
    {
        public List<ContinentSingletonData> ListeContinent { get; set; }
        FootContexte context = new FootContexte();
        #region Constucteur par déffaut
        ContinentSingletonDatas() { }
        #endregion
        #region Constucteur avec idContinent
        public ContinentSingletonDatas(int idContinent)
        {
            ListeContinent = new List<ContinentSingletonData>();
            var liste = context.GetContinent(idContinent);
            foreach (var c in liste)
            {
                var continent = ContinentSingletonData.Instance;
                continent.Id = c.Id;
                continent.NomContinent = c.Nom;
                ListeContinent.Add(continent);
            }
        }
        #endregion
    }
    #endregion
}
