using System.Collections.Generic;
using System.Web.Http;
using DataAccessLayer;
using DataAccessLayer.DomainModel;
using DataTransferObjects.Converters;
using DataTransferObjects.DTO;

namespace Rest_Api.Controllers
{
    public class PictureApiController : ApiController
    {
        // GET: api/PictureApi
        public IEnumerable<PictureDto> GetPictures()
        {
            var pictures = new Facade().GetPictureRepository().ReadAll();
            return new PictureDtoConverter().Convert(pictures);
        }

        // GET api/PictureApi
        public PictureDto Get(int id)
        {
            var picture = new Facade().GetPictureRepository().Read(id);
            return new PictureDtoConverter().Convert(picture);
        }

        // POST api/PictureApi
        public void PostPicture(DomainModelPicture domainModelPicture)
        {
            new Facade().GetPictureRepository().Create(domainModelPicture);
        }

        // PUT: api/PictureApi
        public PictureDto PutPicture(DomainModelPicture domainModelPicture)
        {
            var picture = new Facade().GetPictureRepository().Update(domainModelPicture);
            return new PictureDtoConverter().Convert(picture);
        }

        // DELETE: api/PictureApi
        public void DeletePicture(int id)
        {
            new Facade().GetPictureRepository().Delete(id);
        }
    }
}