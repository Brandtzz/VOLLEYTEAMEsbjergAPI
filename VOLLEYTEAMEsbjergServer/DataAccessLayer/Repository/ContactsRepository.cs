using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataAccessLayer.Repository
{
    class ContactsRepository : ICrud<DomainModelContacts>
    {
        public List<DomainModelContacts> ReadAll()
        {
            using (var context = new Context.Context())
            {

                List<DomainModelContacts> boardList = context.Set<DomainModelContacts>().ToList();
                return boardList;
            }
        }

        public DomainModelContacts Read(int Id)
        {
            DomainModelContacts contacts = null;
            using (var context = new Context.Context())
            {
                contacts =
                     context.Set<DomainModelContacts>().Where(domainModelContacts => domainModelContacts.Id == Id).FirstOrDefault();
            }
            return contacts;
        }

        public void Create(DomainModelContacts entity)
        {
            using (var context = new Context.Context())
            {
                context.Set<DomainModelContacts>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var context = new Context.Context())
            {
                DomainModelContacts contacts =
                    context.Set<DomainModelContacts>().Where(domainModelContacts => domainModelContacts.Id == Id).FirstOrDefault();
                if (contacts != null)
                {
                    context.Set<DomainModelContacts>().Remove(contacts);
                }
                context.SaveChanges();
            }
        }

        public DomainModelContacts Update(DomainModelContacts entity)
        {
            using (var context = new Context.Context())
            {
                DomainModelContacts contacts =
                    context.Set<DomainModelContacts>()
                        .Where(domainModelContacts => domainModelContacts.Id == entity.Id)
                        .FirstOrDefault();
                if (contacts != null)
                {
                    contacts.Contacts = entity.Contacts;
                }
                context.SaveChanges();
                return contacts;
            }
        }
    }
}
