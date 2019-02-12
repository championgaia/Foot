using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class TranferViewModel
    {
        public int IdTransferVM { get; set; }
        public int FkJoueurVM { get; set; }
        public int FkEquipeDepartVM { get; set; }
        public int FkEquipeArriveVM { get; set; }
        public int PrixTransferVM { get; set; }
        public int PrixSupVM { get; set; }
    }
}