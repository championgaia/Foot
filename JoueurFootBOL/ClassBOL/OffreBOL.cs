using System;
using System.Linq;

namespace JoueurFootBOL
{
    #region MyRegion
    internal class OffreBOL
    {
        public int IdJoueur { get; set; }
        public int PrixOffre { get; set; }
        Random Rnd = new Random();
        #region faire une offre Bol
        public bool CreateOffreBol(OffreBOL offre)
        {
            var joueur = new JoueurBOLs(-1, -1, -1, -1, offre.IdJoueur).ListeJoueur.FirstOrDefault();
            if (offre.PrixOffre < joueur.PrixMin)
                return false;
            else if ((offre.PrixOffre > joueur.PrixMax) && (joueur.PrixMax != null))
                return true;
            else
                return true;
        }
        #endregion
    }
    #endregion

}
