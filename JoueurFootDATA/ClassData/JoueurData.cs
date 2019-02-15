using System;
using System.Collections.Generic;

namespace JoueurFootDATA
{
    #region JoueurData
    internal class JoueurData
    {
        public int Id { get; set; }
        public string NomJoueur { get; set; }
        public string PreNom { get; set; }
        public DateTime DateNaissance { get; set; }
        public DateTime DateDebutContrat{ get; set; }
        public DateTime DateFinContrat { get; set; }
        public int SalaireHebdomadaire{ get; set; }
        public double? PrixMax { get; set; }
        public int? Taille { get; set; }
        public int? Poid { get; set; }
        public string Position { get; set; }
        public string NomEquipe { get; set; }
        public string NomPays { get; set; }
        public string NomContinent { get; set; }
        public string NomPrenomAgent { get; set; }
        public int FkContinent { get; set; }
        public int FkPays { get; set; }
        public int FkEquipe { get; set; }
        public int FkPosition { get; set; }
    }
    #endregion
    #region JoueurDatas : liste des joueurs
    internal class JoueurDatas
    {
        public List<JoueurData> ListeJoueur { get; set; }
        private FootContexte context = new FootContexte();
        public JoueurDatas(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            ListeJoueur = new List<JoueurData>();
            var liste = context.GetPlayer(idContinent, idPays, idEquipe, idPosition, idJoueur);
            foreach (var c in liste)
            {
                ListeJoueur.Add(new JoueurData
                {
                    Id = c.Id,
                    NomJoueur = c.NomJoueur,
                    PreNom = c.PrenomJoueur,
                    DateNaissance = c.DateNaissance,
                    DateDebutContrat = c.DateDebutContrat,
                    DateFinContrat = c.DateFinContrat,
                    SalaireHebdomadaire = c.SalaireHebdomadaire,
                    Position = c.PositionNom,
                    NomEquipe = c.NomEquipe,
                    NomContinent = c.NomContinent,
                    NomPays = c.NomPays,
                    NomPrenomAgent = c.NomAgent + " " + c.PrenomAgent,
                    FkContinent = c.FkContinent,
                    FkPays = c.FkPays,
                    FkEquipe = c.FkEquipe,
                    FkPosition = c.FkPosition
                });
            }
        }
    }
    #endregion
}
