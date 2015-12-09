using DataAccessLayer.DomainModel;
using DataTransferObjects.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects.Converters
{
    public class EnglishDtoConverter : AbstractDtoConverter<DomainModelEnglish, EnglishDto>
    {
        public override EnglishDto Convert(DomainModelEnglish domainModelEnglish)
        {
            var dto = new EnglishDto()
            {
                Id = domainModelEnglish.Id,
                English = domainModelEnglish.English
            };
            return dto;
        }
    }
}


