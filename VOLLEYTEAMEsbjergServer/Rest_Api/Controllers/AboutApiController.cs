using DataTransferObjects.Converters;
using System.Collections.Generic;
using System.Web.Http;
using DataAccessLayer;
using DataAccessLayer.DomainModel;

namespace Rest_Api.Controllers
{
    public class AboutApiController : ApiController
    {
        // GET: api/AboutApi
        public IEnumerable<AboutDto> GetAbouts()
        {
            var abouts = new Facade().GetAboutRepository().ReadAll();
            return new AboutDtoConverter().Convert(abouts); 
        }

        // GET: api/AboutApi/5
        public AboutDto Get(int id)
        {
            var about = new Facade().GetAboutRepository().Read(id);
            return new AboutDtoConverter().Convert(about);
        }

        // POST: api/AboutApi
        public void PostAbout(DomainModelAbout domainModelAbout)
        {
            new Facade().GetAboutRepository().Create(domainModelAbout);
            
        }

        // PUT: api/AboutApi/5
        public AboutDto PutAbout(DomainModelAbout domainModelAbout)
        {
            var about = new Facade().GetAboutRepository().Update(domainModelAbout);
            return new AboutDtoConverter().Convert(about); 
        }

        // DELETE: api/AboutApi/5
        public void DeleteAbout(int id)
        {
             new Facade().GetAboutRepository().Delete(id);
        }
    }
}
