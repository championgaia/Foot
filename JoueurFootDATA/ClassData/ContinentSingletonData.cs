using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoueurFootDATA
{
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
}
