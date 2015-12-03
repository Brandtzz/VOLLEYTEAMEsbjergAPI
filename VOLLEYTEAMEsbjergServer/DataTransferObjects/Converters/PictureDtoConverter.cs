using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;
using DataTransferObjects.DTO;

namespace DataTransferObjects.Converters
{
    public class PictureDtoConverter : AbstractDtoConverter<DomainModelPicture, PictureDto>
    {
        public override PictureDto Convert(DomainModelPicture domainModelPicture)
        {
            var dto = new PictureDto()
            {
                Id = domainModelPicture.Id,
                Picture = domainModelPicture.Picture,
                PictureName = domainModelPicture.PictureName
            };
            return dto;
        }
    }
}
