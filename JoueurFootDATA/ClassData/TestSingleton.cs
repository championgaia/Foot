using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoueurFootDATA
{
    #region Première version - Non thread-safe
    internal sealed class TestSingleton
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        static TestSingleton instance = null;
        #region constructor par déffaut privé
        TestSingleton() { }
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
    #endregion
    #region Seconde version - Simple thread-safety
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }
    #endregion
    #region Troisième version - Tenter thread-safety en utilisant une double vérification du verrouillage
    // Bad code! Do not use!
    public sealed class Singleton3
    {
        private static Singleton3 instance = null;
        private static readonly object padlock = new object();

        Singleton3()
        {
        }

        public static Singleton3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton3();
                        }
                    }
                }
                return instance;
            }
        }
    }
    #endregion
    #region Quatrième version - Pas tout à fait en différé, mais thread-safe sans utiliser de verrous
    public sealed class Singleton4
    {
        private static readonly Singleton4 instance = new Singleton4();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton4()
        {
        }

        private Singleton4()
        {
        }

        public static Singleton4 Instance
        {
            get
            {
                return instance;
            }
        }
    }
    #endregion
    #region Cinquième version - Instanciation totalement différée
    public sealed class Singleton5
    {
        private Singleton5()
        {
        }

        public static Singleton5 Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton5 instance = new Singleton5();
        }
    }
    #endregion
    #region Sixième version - Utiliser le type Lazy<T> de .NET 4
    public sealed class Singleton6
    {
        private static readonly Lazy<Singleton6> lazy =
            new Lazy<Singleton6>(() => new Singleton6());

        public static Singleton6 Instance { get { return lazy.Value; } }

        private Singleton6()
        {
        }
    }
    #endregion
}
