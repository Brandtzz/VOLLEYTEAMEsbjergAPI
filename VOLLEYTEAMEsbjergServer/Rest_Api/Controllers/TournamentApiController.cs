using DataAccessLayer;
using DataAccessLayer.DomainModel;
using DataTransferObjects.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rest_Api.Controllers
{
    public class TournamentApiController : ApiController
    {
        Facade facade = new Facade();

        // GET: api/TournamentApi
        public IEnumerable<TournamentDto> GetTournaments()
        {
            var tournaments = new Facade().GetTournamentRepository().ReadAll();
            return new TournamentDtoConverter().Convert(tournaments);
        }

        // GET: api/TournamentApi/5
        public TournamentDto GetTournament(int id)
        {
            var tournament = new Facade().GetTournamentRepository().Read(id);
            return new TournamentDtoConverter().Convert(tournament);
        }

        // POST: api/TournamentApi
        public void PostTournament(DomainModelTournament domainModelTournament)
        {
            new Facade().GetTournamentRepository().Create(domainModelTournament);
        }

        // PUT: api/TournamentApi/5
        public TournamentDto PutTournament(DomainModelTournament domainModelTournament)
        {
            var tournament = new Facade().GetTournamentRepository().Update(domainModelTournament);
            return new TournamentDtoConverter().Convert(tournament);
        }

        // DELETE: api/TournamentApi/5
        public void DeleteTournament(int id)
        {
            new Facade().GetTournamentRepository().Delete(id);
        }
    }
}
