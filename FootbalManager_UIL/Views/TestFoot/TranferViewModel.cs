using JoueurFoot_UIL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootbalManager_UIL
{
    public class TranferViewModel
    {
        public int IdTransferVM { get; set; } = 0;
        public JoueurModel JoueurVM { get; set; }
        public EquipeModel OldEquipeVM { get; set; }
        public EquipeModel NewEquipeVM { get; set; }
        public double PrixTransferVM { get; set; }
        public double PrixSupVM { get; set; }
    }
}