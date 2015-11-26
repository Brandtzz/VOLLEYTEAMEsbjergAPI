using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataTransferObjects.DTO
{
    public class ContactsDtoConverter : AbstractDtoConverter<DomainModelContacts, ContactsDto>
    {
        public override ContactsDto Convert(DomainModelContacts domainModelContacts)
        {
            var dto = new ContactsDto()
            {
                Id = domainModelContacts.Id,
                Contacts = domainModelContacts.Contacts
            };
            return dto;
        }
    }
}
