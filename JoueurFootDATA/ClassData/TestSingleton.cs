using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoueurFootDATA
{
    internal sealed class TestSingleton
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        static TestSingleton instance = null;
        #region constructor par déffaut privé
        TestSingleton(){ }
        #endregion
        #region gestion d'instanciation
        public static TestSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TestSingleton();
                }
                return instance;
            }
        }
        #endregion
    }
}
