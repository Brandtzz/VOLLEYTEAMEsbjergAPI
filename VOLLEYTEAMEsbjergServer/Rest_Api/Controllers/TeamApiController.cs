using DataAccessLayer;
using DataAccessLayer.DomainModel;
using DataTransferObjects.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rest_Api.Controllers
{
    public class TeamApiController : ApiController
    {
        Facade facade = new Facade();

        // GET: api/Team
        public IEnumerable<TeamDto> GetTeams()
        {
            var teams = new Facade().GetTeamRepository().ReadAll();
            return new TeamDtoConverter().Convert(teams);
        }

        // GET: api/Team/5
        public TeamDto GetTeam(int id)
        {
            var team = new Facade().GetTeamRepository().Read(id);
            return new TeamDtoConverter().Convert(team);
        }

        // POST: api/Team
        public void PostTeam(DomainModelTeam domainModelTeam)
        {
            new Facade().GetTeamRepository().Create(domainModelTeam);
        }

        // PUT: api/Team/5
        public TeamDto PutTeam(DomainModelTeam domainModelTeam)
        {
            var team = new Facade().GetTeamRepository().Update(domainModelTeam);
            return new TeamDtoConverter().Convert(team);
        }

        // DELETE: api/Team/5
        public void DeleteTeam(int id)
        {
            new Facade().GetTeamRepository().Delete(id);
        }
    }
}
