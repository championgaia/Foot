using FootbalManager_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class MakeOffreViewModel
    {
        public int IdJoueurVM { get; set; }
        public string NomJoueurVM { get; set; }
        public string PreNomJoueurVM { get; set; }
        public int FkPositionVM { get; set; }
        public string NomPositionVM { get; set; }
        public int FkContinentVM { get; set; }
        public int FkPaysVM { get; set; }
        public int FkEquipeVM { get; set; }
        public string NomEquipeVM { get; set; }
        public double PrixOffreVM { get; set; }
        public string Message { get; set; }
    }
}