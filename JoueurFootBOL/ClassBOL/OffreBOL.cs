using System;
using System.Linq;

namespace JoueurFootBOL
{
    #region MyRegion
    internal class OffreBOL
    {
        public int FkContinent { get; set; }
        public int FkPays { get; set; }
        public int FkEquipe { get; set; }
        public int FkPosition { get; set; }
        public int IdJoueur { get; set; }
        public double PrixOffre { get; set; }
        Random Rnd = new Random();
        #region faire une offre Bol
        public bool CreateOffreBol(OffreBOL offre)
        {
            var joueur = new JoueurBOLs(offre.FkContinent, offre.FkPays, offre.FkEquipe, offre.FkPosition, offre.IdJoueur).ListeJoueur.FirstOrDefault();
            if (offre.PrixOffre < joueur.PrixMin)
                return false;
            else if ((offre.PrixOffre > joueur.PrixMax) && (joueur.PrixMax != null))
                return true;
            else
                return Rnd.Next(1,4)>2;
        }
        #endregion
    }
    #endregion

}
