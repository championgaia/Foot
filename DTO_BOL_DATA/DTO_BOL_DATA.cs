using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BOL_DATA
{
    #region ContinentDTO
    public class ContinentDTO
    {
        public int IdDto { get; set; }
        public string NomContinentDto { get; set; }
    }
    #endregion
    #region PaysDTO
    public class PaysDTO
    {
        public int IdDto { get; set; }
        public string NomPaysDto { get; set; }
    }
    #endregion
    #region PositionDTO
    public class PositionDTO
    {
        public int IdDto { get; set; }
        public string NomPositionDTO { get; set; }
    }
    #endregion
    #region EquipeDTO
    public class EquipeDTO
    {
        public int IdDto { get; set; }
        public string NomEquipeDto { get; set; }
        public string SurNomDto { get; set; }
        public string AbreviationDto { get; set; }
        public DateTime DateFondationDto { get; set; }
        public string PdgDto { get; set; }
        public string EntraineurDto { get; set; }
        public string NomStadeDto { get; set; }
        public int NbrCoupeNationDto { get; set; }
        public int NbrCoupeContinentalDto { get; set; }
        public string NomPaysDto { get; set; }
        public string NomContinentDto { get; set; }
    }
    #endregion
    #region JoueurDTO
    public class JoueurDTO
    {
        public int IdDto { get; set; }
        public string NomJoueurDto { get; set; }
        public string PrenomDto { get; set; }
        public DateTime DateNaissanceDto { get; set; }
        public DateTime DateDebutContratDto { get; set; }
        public DateTime DateFinContratDto { get; set; }
        public int SalaireHebdomadaireDto { get; set; }
        public double? PrixMaxDto { get; set; }
        public int? TailleDto { get; set; }
        public int? PoidDto { get; set; }
        public string PositionDto { get; set; }
        public string NomEquipeDto { get; set; }
        public string NomPaysDto { get; set; }
        public string NomContinentDto { get; set; }
        public string NomPrenomAgentDto { get; set; }
    }
    #endregion
    #region TestSingleton
    public sealed class TestSingletonDto
    {
        public int IdDto { get; set; }
        public string NomDto { get; set; }
    }
    #endregion
}
