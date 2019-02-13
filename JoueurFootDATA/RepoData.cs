using DTO_BOL_DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoueurFootDATA
{
    public class RepoData
    {
        #region GetContinentDTOs
        public List<ContinentDTO> GetContinentDTOs(int idContinent)
        {
            ContinentDatas continents = new ContinentDatas(idContinent);
            var liste = continents.ListeContinent;
            List<ContinentDTO> listeDto = new List<ContinentDTO>();
            foreach (var c in liste)
            {
                listeDto.Add(new ContinentDTO { IdDto = c.Id, NomContinentDto = c.NomContinent });
            }
            return listeDto;
        }
        #endregion
        #region GetPaysDTOs
        public List<PaysDTO> GetPaysDTOs(int idContinent, int idPays)
        {
            PaysDatas continents = new PaysDatas(idContinent, idPays);
            var liste = continents.ListePays;
            List<PaysDTO> listeDto = new List<PaysDTO>();
            foreach (var c in liste)
            {
                listeDto.Add(new PaysDTO { IdDto = c.Id, NomPaysDto = c.NomPays });
            }
            return listeDto;
        }
        #endregion
        #region GetPositionDTOs
        public List<PositionDTO> GetPositionDTOs(int idJoueur)
        {
            PositionDatas positions = new PositionDatas(idJoueur);
            var liste = positions.ListePosition;
            List<PositionDTO> listeDto = new List<PositionDTO>();
            foreach (var c in liste)
            {
                listeDto.Add(new PositionDTO { IdDto = c.Id, NomPositionDTO = c.PositionNom });
            }
            return listeDto;
        }
        #endregion
        #region EquipeRepoDatasDTO : liste des équipes
        public List<EquipeDTO> GetEquipeDTOs(int idContinent, int idPays, int idEquipe)
        {
            EquipeDatas equipeDatas = new EquipeDatas(idContinent, idPays, idEquipe);
            var liste = equipeDatas.ListeEquipe;
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
                    NomPaysDto = c.NomPays
                });
            }
            return listeDto;
        }
        #endregion
        #region JoueurRepoDatasDTO : liste des joueurs

        public List<JoueurDTO> GetJoueur(int idContinent, int idPays, int idEquipe, int idPosition, int idJoueur)
        {
            JoueurDatas joueurDatas = new JoueurDatas(idContinent, idPays, idEquipe, idPosition, idJoueur);
            var ListeJoueurDTO = new List<JoueurDTO>();
            var liste = joueurDatas.ListeJoueur;
            foreach (var c in liste)
            {
                ListeJoueurDTO.Add(new JoueurDTO
                {
                    IdDto = c.Id,
                    NomJoueurDto = c.NomJoueur,
                    PrenomDto = c.PreNom,
                    DateNaissanceDto = c.DateNaissance,
                    DateDebutContratDto = c.DateDebutContrat,
                    DateFinContratDto = c.DateFinContrat,
                    SalaireHebdomadaireDto = c.SalaireHebdomadaire,
                    PositionDto = c.Position,
                    NomEquipeDto = c.NomEquipe,
                    NomContinentDto = c.NomContinent,
                    NomPaysDto = c.NomPays,
                    NomPrenomAgentDto = c.NomPrenomAgent
                });
            }
            return ListeJoueurDTO;
        }

        #endregion

        #region Singleton test RepoData
        #region TestSingleton
        public TestSingletonDto GetTestSingleton()
        {
            var test = TestSingleton.Instance;
            var testDto = new TestSingletonDto
            {
                IdDto = test.Id,
                NomDto = test.Nom
            };
            return testDto;
        }
        #endregion
        #region GetContinentSingletonDTOs
        public List<ContinentDTO> GetContinentSingletonDTOs(int idContinent)
        {
            ContinentSingletonDatas continents = new ContinentSingletonDatas(idContinent);
            var liste = continents.ListeContinent;
            List<ContinentDTO> listeDto = new List<ContinentDTO>();
            foreach (var c in liste)
            {
                listeDto.Add(new ContinentDTO { IdDto = c.Id, NomContinentDto = c.NomContinent });
            }
            return listeDto;
        }
        #endregion
        #endregion
    }
}
