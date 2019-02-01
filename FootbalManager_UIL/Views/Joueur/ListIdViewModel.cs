using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class ListIdViewModel
    {
        public int  IdContinent { get; set; } = -1;
        public int  IdPays { get; set; } = -1;
        public int  IdEquipe { get; set; } = -1;
        public int  IdPosition { get; set; } = -1;
        public int  IdJoueur { get; set; } = -1;
        public ListIdViewModel()
        {

        }
        public ListIdViewModel(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            IdContinent = idContinent;
            IdPays = idPays;
            IdEquipe = idEquipe;
            IdPosition = idPosition;
            IdJoueur = idJoueur;
        }
    }
}