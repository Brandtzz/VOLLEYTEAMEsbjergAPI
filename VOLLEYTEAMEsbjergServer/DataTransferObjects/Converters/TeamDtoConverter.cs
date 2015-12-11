using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataTransferObjects.Converters
{
    public class TeamDtoConverter : AbstractDtoConverter<DomainModelTeam, TeamDto>
    {
        public override TeamDto Convert(DomainModelTeam domainModelTeam)
        {
            var dto = new TeamDto()
            {
                Id = domainModelTeam.Id,
                Name = domainModelTeam.Name,
                Description = domainModelTeam.Description,
                Intro = domainModelTeam.Intro
            };
            return dto;
        }
    }
}
