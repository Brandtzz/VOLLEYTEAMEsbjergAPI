using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataTransferObjects.Converters
{
    public class ContactsDtoConverter : AbstractDtoConverter<DomainModelContacts, ContactsDto>
    {
        public override ContactsDto Convert(DomainModelContacts domainModelContacts)
        {
            var dto = new ContactsDto()
            {
                Id = domainModelContacts.Id,
                FirstName = domainModelContacts.FirstName,
                LastName = domainModelContacts.LastName,
                Email = domainModelContacts.Email,
                Phone = domainModelContacts.Phone,
             
            };
            return dto;
        }
    }
}
