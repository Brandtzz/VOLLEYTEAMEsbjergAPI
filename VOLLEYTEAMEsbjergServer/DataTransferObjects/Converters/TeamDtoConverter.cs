using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataTransferObjects.DTO
{
    public class TeamDtoConverter : AbstractDtoConverter<DomainModelTeam, TeamDto>
    {
        public override TeamDto Convert(DomainModelTeam domainModelTeam)
        {
            var dto = new TeamDto()
            {
                Id = domainModelTeam.Id,
                Team = domainModelTeam.Team
            };
            return dto;
        }
    }
}
