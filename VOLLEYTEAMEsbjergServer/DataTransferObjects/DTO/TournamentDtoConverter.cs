using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataTransferObjects.DTO
{
    public class TournamentDtoConverter : AbstractDtoConverter<DomainModelTournament, TournamentDto>
    {
        public override TournamentDto Convert(DomainModelTournament domainModelTournament)
        {
            var dto = new TournamentDto()
            {
                Id = domainModelTournament.Id,
                Tournament = domainModelTournament.Tournament
            };
            return dto;
        }
    }
}
