using DataAccessLayer;
using DataAccessLayer.DomainModel;
using DataTransferObjects.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rest_Api.Controllers
{
    public class NewsApiController : ApiController
    {
        Facade facade = new Facade();

        // GET: api/News
        public IEnumerable<NewsDto> GetNews()
        {
            var news = new Facade().GetNewsRepository().ReadAll();
            return new NewsDtoConverter().Convert(news);
        }

        // GET: api/News/5
        public NewsDto GetNews(int id)
        {
            var news = new Facade().GetNewsRepository().Read(id);
            return new NewsDtoConverter().Convert(news);
        }

        // POST: api/News
        public void PostNews(DomainModelNews domainModelNews)
        {
            new Facade().GetNewsRepository().Create(domainModelNews);
        }

        // PUT: api/News/5
        public NewsDto PutNews(DomainModelNews domainModelNews)
        {
            var news = new Facade().GetNewsRepository().Update(domainModelNews);
            return new NewsDtoConverter().Convert(news);
        }

        // DELETE: api/News/5
        public void DeleteNews(int id)
        {
            new Facade().GetNewsRepository().Delete(id);
        }
    }
}
