using System.Collections.Generic;
using System;
namespace JoueurFootDATA
{
    #region EquipeData
    internal class EquipeData
    {
        public int Id { get; set; }
        public string NomEquipe { get; set; }
        public string SurNom { get; set; }
        public string Abreviation { get; set; }
        public DateTime DateFondation { get; set; }
        public string Pdg { get; set; }
        public string Entraineur { get; set; }
        public string NomStade { get; set; }
        public int NbrCoupeNation { get; set; }
        public int NbrCoupeContinental { get; set; }
        public string NomPays { get; set; }
        public string NomContinent { get; set; }
        public int FkContinent { get; set; }
        public int FkPays { get; set; }
    }
    #endregion
    #region EquipeDatas : liste des équipes
    internal class EquipeDatas
    {
        public List<EquipeData> ListeEquipe { get; set; }
        private FootContexte context = new FootContexte();
        public EquipeDatas(int idContinent, int idPays, int idEquipe)
        {
            ListeEquipe = new List<EquipeData>();
            var liste = context.GetClub(idContinent, idPays, idEquipe);
            foreach (var c in liste)
            {
                ListeEquipe.Add(new EquipeData {
                    Id = c.Id,
                    NomEquipe = c.NomEquipe,
                    SurNom = c.SurNom,
                    Abreviation = c.Abreviation,
                    DateFondation = c.DateFondation,
                    Pdg = c.PDG,
                    Entraineur = c.Entraineur,
                    NomStade = c.NomStade,
                    NbrCoupeNation = c.NombreCoupeNation,
                    NbrCoupeContinental = c.NombreCoupeContinental,
                    NomContinent = c.NomContinent,
                    NomPays = c.NomPays,
                    FkContinent = c.FkContinent,
                    FkPays = c.FkPays
                });
            }
        }
    }
    #endregion
}
