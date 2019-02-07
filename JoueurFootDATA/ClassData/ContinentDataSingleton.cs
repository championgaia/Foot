using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoueurFootDATA.ClassData
{
    #region ContinentDataSingleton
    internal class ContinentDataSingleton
    {
        public int Id { get; set; }
        public string NomContinent { get; set; }
    }
    #endregion
    //version 2 add singleton sur la classe contient liste => pas intéret
    #region ContinentDataSingletons : liste des continents
    internal class ContinentDataSingletons : List<ContinentDataSingleton>
    {
        static ContinentDataSingletons ListeContinent = null;
        FootContexte context = new FootContexte();
        #region Constructeur par déffaut
        ContinentDataSingletons() { }
        #endregion
        #region gestion d'instanciation
        public static ContinentDataSingletons Instance
        {
            get
            {
                if (ListeContinent == null)
                {
                    ListeContinent = new ContinentDataSingletons();
                }
                return ListeContinent;
            }
        }
        #endregion
        #region Constucteur avec idContinent
        public ContinentDataSingletons(int idContinent)
        {
            ListeContinent = new ContinentDataSingletons();
            var liste = context.GetContinent(idContinent);
            foreach (var c in liste)
            {
                ListeContinent.Add(new ContinentDataSingleton {
                    Id = c.Id,
                    NomContinent = c.Nom
                });
            }
        }
        #endregion
    }
    #endregion
}
