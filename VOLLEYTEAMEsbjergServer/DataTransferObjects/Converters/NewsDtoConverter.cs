using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataTransferObjects.Converters
{
    public class NewsDtoConverter : AbstractDtoConverter<DomainModelNews, NewsDto>
    {
        public override NewsDto Convert(DomainModelNews domainModelNews)
        {
            var dto = new NewsDto()
            {
                Id = domainModelNews.Id,
                News = domainModelNews.News
            };
            return dto;
        }
    }
}
