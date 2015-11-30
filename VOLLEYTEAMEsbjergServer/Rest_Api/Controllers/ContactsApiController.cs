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
    public class ContactsApiController : ApiController
    {
        Facade facade = new Facade();

        // GET: api/ContactsApi
        public IEnumerable<ContactsDto> GetContacts()
        {
            var contacts = new Facade().GetContactRepository().ReadAll();
            return new ContactsDtoConverter().Convert(contacts);
        }

        // GET: api/ContactsApi/5
        public ContactsDto GetContacts(int id)
        {
            var contact = new Facade().GetContactRepository().Read(id);
            return new ContactsDtoConverter().Convert(contact);
        }

        // POST: api/ContactsApi
        public void PostContacts(DomainModelContacts domainModelContacts)
        {
            new Facade().GetContactRepository().Create(domainModelContacts);
        }

        // PUT: api/ContactsApi/5
        public ContactsDto PutContacts(DomainModelContacts domainModelContacts)
        {
            var contact = new Facade().GetContactRepository().Update(domainModelContacts);
            return new ContactsDtoConverter().Convert(contact);
        }

        // DELETE: api/ContactsApi/5
        public void DeleteContacts(int id)
        {
            new Facade().GetContactRepository().Delete(id);
        }
    }
}
