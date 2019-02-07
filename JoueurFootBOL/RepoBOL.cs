using ClassBOL;
using DTO_UIL_BOL;
using System.Collections.Generic;

namespace JoueurFootBOL
{
    public class RepoBol
    {
        #region GetContinentDTOs Repo BOL
        public List<ContinentDTO> GetContinentDTOs(int idContinent)
        {
            ContinentBOLs continents = new ContinentBOLs(idContinent);
            var liste = continents.ListeContinent;
            List<ContinentDTO> listeDto = new List<ContinentDTO>();
            foreach (var c in liste)
            {
                listeDto.Add(new ContinentDTO { IdDto = c.Id, NomContinentDto = c.NomContinent });
            }
            return listeDto;
        }
        #endregion
        #region GetPaysDTOs  Repo BOL
        public List<PaysDTO> GetPaysDTOs(int idContinent, int idPays)
        {
            PaysBOLs continents = new PaysBOLs(idContinent, idPays);
            var liste = continents.ListePays;
            List<PaysDTO> listeDto = new List<PaysDTO>();
            foreach (var c in liste)
            {
                listeDto.Add(new PaysDTO { IdDto = c.Id, NomPaysDto = c.NomPays });
            }
            return listeDto;
        }
        #endregion
        #region GetPositionDTOs Repo BOL
        public List<PositionDTO> GetPositionDTOs(int idPosition)
        {
            PositionBOLs positions = new PositionBOLs(idPosition);
            var liste = positions.ListePosition;
            List<PositionDTO> listeDto = new List<PositionDTO>();
            foreach (var c in liste)
            {
                listeDto.Add(new PositionDTO { IdDto = c.Id, NomPositionDTO = c.NomPosition });
            }
            return listeDto;
        }
        #endregion
        #region EquipeRepoBOL : liste des équipes
        public List<EquipeDTO> GetEquipeDTOs(int idContinent, int idPays, int idEquipe)
        {
            EquipeBOLs equipeBOLs = new EquipeBOLs(idContinent, idPays, idEquipe);
            var liste = equipeBOLs.ListeEquipe;
            List<EquipeDTO> listeDto = new List<EquipeDTO>();
            foreach (var c in liste)
            {
                listeDto.Add(new EquipeDTO
                {
                    IdDto = c.Id,
                    NomEquipeDto = c.NomEquipe,
                    SurNomDto = c.SurNom,
                    DateFondationDto = c.DateFondation,
                    PdgDto = c.Pdg,
                    EntraineurDto = c.Entraineur,
                    NomStadeDto = c.NomStade,
                    NbrCoupeNationDto = c.NbrCoupeNation,
                    NbrCoupeContinentalDto = c.NbrCoupeContinental,
                    NomContinentDto = c.NomContinent,
                    NomPaysDto = c.NomPays,
                });
            }
            return listeDto;
        }
        #endregion
        #region JoueurRepoBOL : liste des joueurs
        public List<JoueurDTO> GetJoueur(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            JoueurBOLs joueurBols = new JoueurBOLs(idContinent, idPays, idEquipe, idPosition, idJoueur);
            var ListeJoueurDTO = new List<JoueurDTO>();
            var liste = joueurBols.ListeJoueur;
            foreach (var c in liste)
            {
                ListeJoueurDTO.Add(new JoueurDTO
                {
                    IdDto = c.Id,
                    NomJoueurDto = c.NomJoueur,
                    PrenomDto = c.Prenom,
                    DateNaissanceDto = c.DateNaissance,
                    DateDebutContratDto = c.DateDebutContrat,
                    DateFinContratDto = c.DateFinContrat,
                    SalaireHebdomadaireDto = c.SalaireHebdomadaire,
                    PrixMinDto = c.PrixMin,
                    PositionDto = c.Position,
                    NomEquipeDto = c.NomEquipe,
                    NomContinentDto = c.NomContinent,
                    NomPaysDto = c.NomPays,
                    NomPrenomAgentDto =c.NomPrenomAgent
                });
            }
            return ListeJoueurDTO;
        }
        #endregion
    }
}
