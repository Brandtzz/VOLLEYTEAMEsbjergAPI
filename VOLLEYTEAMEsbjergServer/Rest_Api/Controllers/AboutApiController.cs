using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rest_Api.Controllers
{
    public class AboutApiController : ApiController
    {
        // GET: api/AboutApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AboutApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AboutApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AboutApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AboutApi/5
        public void Delete(int id)
        {
        }
    }
}
