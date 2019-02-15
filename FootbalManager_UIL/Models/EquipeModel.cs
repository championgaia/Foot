using JoueurFootBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoueurFoot_UIL.Models
{
    #region EquipeModel
    public class EquipeModel
    {
        public int IdM { get; set; }
        public string NomEquipeM { get; set; }
        public string SurNomM { get; set; }
        public string AbreviationM { get; set; }
        public DateTime DateFondationM { get; set; }
        public string PdgM { get; set; }
        public string EntraineurM { get; set; }
        public string NomStadeM { get; set; }
        public int NbrCoupeNationM { get; set; }
        public int NbrCoupeContinentalM { get; set; }
        public string NomPaysM { get; set; }
        public string NomContinentM { get; set; }
        public int FkContinentM { get; set; }
        public int FkPaysM { get; set; }
    }
    #endregion
    #region EquipeModels : liste des équipes BOL
    public class EquipeModels
    {
        public List<EquipeModel> ListeEquipeM { get; set; }
        private RepoBol repo = new RepoBol();
        public EquipeModels(int idContinent, int idPays, int idEquipe)
        {
            ListeEquipeM = new List<EquipeModel>();
            var liste = repo.GetEquipeDTOs(idContinent, idPays, idEquipe);
            foreach (var c in liste)
            {
                ListeEquipeM.Add(new EquipeModel
                {
                    IdM = c.IdDto,
                    NomEquipeM = c.NomEquipeDto,
                    SurNomM = c.SurNomDto,
                    AbreviationM = c.AbreviationDto,
                    DateFondationM = c.DateFondationDto,
                    PdgM = c.PdgDto,
                    EntraineurM = c.EntraineurDto,
                    NomStadeM = c.NomStadeDto,
                    NbrCoupeNationM = c.NbrCoupeNationDto,
                    NbrCoupeContinentalM = c.NbrCoupeContinentalDto,
                    NomContinentM = c.NomContinentDto,
                    NomPaysM = c.NomPaysDto,
                    FkContinentM = c.FkContinentDto,
                    FkPaysM = c.FkPaysDto
                });
            }
        }
    }
    #endregion
}