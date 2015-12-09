using DataAccessLayer;
using DataAccessLayer.DomainModel;
using DataTransferObjects.Converters;
using DataTransferObjects.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rest_Api.Controllers
{
    public class EnglishApiController : ApiController
    {

        Facade facade = new Facade(); 

        // GET: api/EnglishApi
        public IEnumerable<EnglishDto> GetAllEnglish()
        {
            var english = new Facade().GetEnglishRepository().ReadAll();
            return new EnglishDtoConverter().Convert(english); 
        }

        // GET: api/EnglishApi/5
        public EnglishDto GetEnglish(int id)
        {
            var english = new Facade().GetEnglishRepository().Read(id);
            return new EnglishDtoConverter().Convert(english); 
        }

        // POST: api/EnglishApi
        public void PostEnglish(DomainModelEnglish domainModelEnglish )
        {
            new Facade().GetEnglishRepository().Create(domainModelEnglish); 
        }

        // PUT: api/EnglishApi/5
        public EnglishDto PutEnglish(DomainModelEnglish domainModelEnglish)
        {
            var english = new Facade().GetEnglishRepository().Update(domainModelEnglish);
            return new EnglishDtoConverter().Convert(english); 
        }

        // DELETE: api/EnglishApi/5
        public void DeleteEnglish(int id)
        {
            new Facade().GetEnglishRepository().Delete(id); 
        }
    }
}
