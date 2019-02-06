using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoueurFootDATA
{
    public sealed class TestSingleton
    {
        //private int Id { get; set; }
        //private string Nom { get; set; }
        static TestSingleton instance = null;
        TestSingleton(){ }
        public static TestSingleton Instance
        {
            get
            {
                if (instance is null)
                {
                    instance = new TestSingleton();
                }
                return instance;
            }
        }
    }
}
