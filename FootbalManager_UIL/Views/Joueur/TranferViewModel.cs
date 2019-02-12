using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class TranferViewModel
    {
        public int IdTransferVM { get; set; } = 0;
        public int FkJoueurVM { get; set; } = 0;
        public string NomEquipeDepartVM { get; set; }
        public string NomEquipeArriveVM { get; set; }
        public double PrixTransferVM { get; set; }
        public double PrixSupVM { get; set; }
    }
}