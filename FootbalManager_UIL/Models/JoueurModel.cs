using JoueurFootBOL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JoueurFoot_UIL.Models
{
    #region JoueurModel
    public class JoueurModel
    {
        public int IdM { get; set; }
        public string NomJoueurM { get; set; }
        public string PrenomM { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DateNaissanceM { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DateDebutContratM { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DateFinContratM { get; set; }
        public int SalaireHebdomadaireM { get; set; }
        public double PrixMinM { get; set; }
        public double? PrixMaxM { get; set; }
        public int? TailleM { get; set; }
        public int? PoidM { get; set; }
        public string PositionM { get; set; }
        public string NomEquipeM { get; set; }
        public string NomPaysM { get; set; }
        public string NomContinentM { get; set; }
        public string NomPrenomAgentM { get; set; }
        public int FkContinentM { get; set; }
        public int FkPaysM { get; set; }
        public int FkEquipeM { get; set; }
    }
    #endregion
    #region JoueurModels : liste des joueurs
    public class JoueurModels
    {
        public List<JoueurModel> ListeJoueurM { get; set; }
        private RepoBol repo = new RepoBol();
        public JoueurModels(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            ListeJoueurM = new List<JoueurModel>();
            var liste = repo.GetJoueur(idContinent, idPays, idEquipe, idPosition, idJoueur);
            foreach (var c in liste)
            {
                ListeJoueurM.Add(new JoueurModel
                {
                    IdM = c.IdDto,
                    NomJoueurM = c.NomJoueurDto,
                    PrenomM = c.PrenomDto,
                    DateNaissanceM = c.DateNaissanceDto,
                    DateDebutContratM = c.DateDebutContratDto,
                    DateFinContratM = c.DateFinContratDto,
                    SalaireHebdomadaireM = c.SalaireHebdomadaireDto,
                    PrixMinM = c.PrixMinDto,
                    PositionM = c.PositionDto,
                    NomEquipeM = c.NomEquipeDto,
                    NomContinentM = c.NomContinentDto,
                    NomPaysM = c.NomPaysDto,
                    NomPrenomAgentM = c.NomPrenomAgentDto,
                    FkContinentM = c.FkContinentDto,
                    FkPaysM = c.FkPaysDto,
                    FkEquipeM = c.FkEquipeDto
                });
            }
        }
    }
    #endregion
}