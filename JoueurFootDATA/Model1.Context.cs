﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JoueurFootDATA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FootContexte : DbContext
    {
        public FootContexte()
            : base("name=FootContexte")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<GetClub_Result> GetClub(Nullable<int> idContinent, Nullable<int> idPays, Nullable<int> idEquipe)
        {
            var idContinentParameter = idContinent.HasValue ?
                new ObjectParameter("idContinent", idContinent) :
                new ObjectParameter("idContinent", typeof(int));
    
            var idPaysParameter = idPays.HasValue ?
                new ObjectParameter("idPays", idPays) :
                new ObjectParameter("idPays", typeof(int));
    
            var idEquipeParameter = idEquipe.HasValue ?
                new ObjectParameter("idEquipe", idEquipe) :
                new ObjectParameter("idEquipe", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetClub_Result>("GetClub", idContinentParameter, idPaysParameter, idEquipeParameter);
        }
    
        public virtual ObjectResult<GetContinent_Result> GetContinent(Nullable<int> idContinent)
        {
            var idContinentParameter = idContinent.HasValue ?
                new ObjectParameter("idContinent", idContinent) :
                new ObjectParameter("idContinent", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetContinent_Result>("GetContinent", idContinentParameter);
        }
    
        public virtual ObjectResult<GetPays_Result> GetPays(Nullable<int> idContinent, Nullable<int> idPays)
        {
            var idContinentParameter = idContinent.HasValue ?
                new ObjectParameter("idContinent", idContinent) :
                new ObjectParameter("idContinent", typeof(int));
    
            var idPaysParameter = idPays.HasValue ?
                new ObjectParameter("idPays", idPays) :
                new ObjectParameter("idPays", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPays_Result>("GetPays", idContinentParameter, idPaysParameter);
        }
    
        public virtual ObjectResult<GetPlayer_Result2> GetPlayer(Nullable<int> idContinent, Nullable<int> idPays, Nullable<int> idEquipe, Nullable<int> idPosition, Nullable<int> idJoueur)
        {
            var idContinentParameter = idContinent.HasValue ?
                new ObjectParameter("idContinent", idContinent) :
                new ObjectParameter("idContinent", typeof(int));
    
            var idPaysParameter = idPays.HasValue ?
                new ObjectParameter("idPays", idPays) :
                new ObjectParameter("idPays", typeof(int));
    
            var idEquipeParameter = idEquipe.HasValue ?
                new ObjectParameter("idEquipe", idEquipe) :
                new ObjectParameter("idEquipe", typeof(int));
    
            var idPositionParameter = idPosition.HasValue ?
                new ObjectParameter("idPosition", idPosition) :
                new ObjectParameter("idPosition", typeof(int));
    
            var idJoueurParameter = idJoueur.HasValue ?
                new ObjectParameter("idJoueur", idJoueur) :
                new ObjectParameter("idJoueur", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPlayer_Result2>("GetPlayer", idContinentParameter, idPaysParameter, idEquipeParameter, idPositionParameter, idJoueurParameter);
        }
    
        public virtual ObjectResult<GetPosition_Result> GetPosition(Nullable<int> idPosition)
        {
            var idPositionParameter = idPosition.HasValue ?
                new ObjectParameter("idPosition", idPosition) :
                new ObjectParameter("idPosition", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPosition_Result>("GetPosition", idPositionParameter);
        }
    }
}
