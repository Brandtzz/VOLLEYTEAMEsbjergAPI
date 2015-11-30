using DataAccessLayer;
using DataAccessLayer.DomainModel;
using DataTransferObjects.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rest_Api.Controllers
{
    public class SponsorApiController : ApiController
    {
        Facade facade = new Facade();

        // GET: api/Sponsor
        public IEnumerable<SponsorDto> GetSponsors()
        {
            var sponsors = new Facade().GetSponsorRepository().ReadAll();
            return new SponsorDtoConverter().Convert(sponsors);
        }

        // GET: api/Sponsor/5
        public SponsorDto GetSponsor(int id)
        {
            var sponsor = new Facade().GetSponsorRepository().Read(id);
            return new SponsorDtoConverter().Convert(sponsor);
        }

        // POST: api/Sponsor
        public void PostSponsor(DomainModelSponsor domainModelSponsor)
        {
            new Facade().GetSponsorRepository().Create(domainModelSponsor);
        }

        // PUT: api/Sponsor/5
        public SponsorDto PutSponsor(DomainModelSponsor domainModelSponsor)
        {
            var sponsor = new Facade().GetSponsorRepository().Update(domainModelSponsor);
            return new SponsorDtoConverter().Convert(sponsor);
        }

        // DELETE: api/Sponsor/5
        public void Delete(int id)
        {
            new Facade().GetSponsorRepository().Delete(id);
        }
    }
}
