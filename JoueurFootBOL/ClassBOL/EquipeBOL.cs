using JoueurFootDATA;
using System;
using System.Collections.Generic;

namespace ClassBOL
{
    #region EquipeBOL
    internal class EquipeBOL
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
    #region EquipeBOLs : liste des équipes BOL
    internal class EquipeBOLs
    {
        public List<EquipeBOL> ListeEquipe { get; set; }
        private RepoData repo = new RepoData();
        public EquipeBOLs(int idContinent, int idPays, int idEquipe)
        {
            ListeEquipe = new List<EquipeBOL>();
            var liste = repo.GetEquipeDTOs(idContinent, idPays, idEquipe);
            foreach (var c in liste)
            {
                ListeEquipe.Add(new EquipeBOL
                {
                    Id = c.IdDto,
                    NomEquipe = c.NomEquipeDto,
                    SurNom = c.SurNomDto,
                    Abreviation = c.AbreviationDto,
                    DateFondation = c.DateFondationDto,
                    Pdg = c.PdgDto,
                    Entraineur = c.EntraineurDto,
                    NomStade = c.NomStadeDto,
                    NbrCoupeNation = c.NbrCoupeNationDto,
                    NbrCoupeContinental = c.NbrCoupeContinentalDto,
                    NomContinent = c.NomContinentDto,
                    NomPays = c.NomPaysDto,
                    FkContinent = c.FkContinentDto,
                    FkPays = c.FkPaysDto
                });
            }
        }
    }
    #endregion
}
