using JoueurFootDATA;
using System;
using System.Collections.Generic;

namespace ClassBOL
{
    #region JoueurBOL
    internal class JoueurBOL
    {
        public int Id { get; set; }
        public string NomJoueur { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public DateTime DateDebutContrat { get; set; }
        public DateTime DateFinContrat { get; set; }
        public int SalaireHebdomadaire { get; set; }
        public int? Taille { get; set; }
        public int? Poid { get; set; }
        public string Position { get; set; }
        public string NomEquipe { get; set; }
        public string NomPays { get; set; }
        public string NomContinent { get; set; }
        public string NomPrenomAgent { get; set; }
    }
    #endregion
    #region JoueurBOL : liste des joueurs
    internal class JoueurBOLs
    {
        public List<JoueurBOL> ListeJoueur { get; set; }
        private RepoData repo = new RepoData();
        public JoueurBOLs(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            ListeJoueur = new List<JoueurBOL>();
            var liste = repo.GetJoueur(idContinent, idPays, idEquipe, idPosition, idJoueur);
            foreach (var c in liste)
            {
                ListeJoueur.Add(new JoueurBOL
                {
                    Id = c.IdDto,
                    NomJoueur = c.NomJoueurDto,
                    Prenom = c.PrenomDto,
                    DateNaissance = c.DateNaissanceDto,
                    DateDebutContrat = c.DateDebutContratDto,
                    DateFinContrat = c.DateFinContratDto,
                    SalaireHebdomadaire = c.SalaireHebdomadaireDto,
                    Position = c.PositionDto,
                    NomEquipe = c.NomEquipeDto,
                    NomContinent = c.NomContinentDto,
                    NomPays = c.NomPaysDto,
                    NomPrenomAgent = c.NomPrenomAgentDto
                });
            }
        }
    }
    #endregion
}
