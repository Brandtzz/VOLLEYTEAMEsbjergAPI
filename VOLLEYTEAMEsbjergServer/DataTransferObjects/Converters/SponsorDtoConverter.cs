using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataTransferObjects.Converters
{
    public class SponsorDtoConverter : AbstractDtoConverter<DomainModelSponsor, SponsorDto>
    {
        public override SponsorDto Convert(DomainModelSponsor domainModelSponsor)
        {
            var dto = new SponsorDto()
            {
                Id = domainModelSponsor.Id,
                Url = domainModelSponsor.Url,
                PictureId = domainModelSponsor.PictureId,
                Name = domainModelSponsor.Name
            };
            return dto;
        }
    }
}
