using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataTransferObjects.DTO
{
    public class AboutDtoConverter : AbstractDtoConverter<DomainModelAbout, AboutDto>
    {
        public override AboutDto Convert(DomainModelAbout domainModelAbout)
        {
            var dto = new AboutDto()
            {
                Id = domainModelAbout.Id,
                About = domainModelAbout.About
            };
            return dto;
        }
    }
}
