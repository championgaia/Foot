using DTO_BOL_DATA;
using JoueurFootDATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JoueurFoot_API.Controllers
{
    public class APIHomeController : ApiController
    {
        RepoData repo = new RepoData();
        #region GetEquipe
        public List<EquipeDTO> GetEquipeAPI(int idContinent, int idPays, int idEquipe)
        {
            return repo.GetEquipeDTOs(idContinent, idPays, idEquipe);
        }
        #endregion
        #region GetJoueur
        public List<JoueurDTO> GetJoueurAPI(int idContinent, int idPays, int idEquipe, int idPosition,int idJoueur)
        {
            return repo.GetJoueur(idContinent, idPays, idEquipe, idPosition, idJoueur);
        }
        #endregion
    }
}
