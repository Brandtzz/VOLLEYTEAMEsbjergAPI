using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataTransferObjects.DTO
{
    public class SponsorDtoConverter : AbstractDtoConverter<DomainModelSponsor, SponsorDto>
    {
        public override SponsorDto Convert(DomainModelSponsor domainModelSponsor)
        {
            var dto = new SponsorDto()
            {
                Id = domainModelSponsor.Id,
                Sponsor = domainModelSponsor.Sponsor
            };
            return dto;
        }
    }
}
