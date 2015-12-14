using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccessLayer.DomainModel;

namespace DataAccessLayer.Repository
{
    public class ContactsRepository : ICrud<DomainModelContacts>
    {
        public List<DomainModelContacts> ReadAll()
        {
            using (var context = new Context.Context())
            {

                List<DomainModelContacts> boardList = context.Set<DomainModelContacts>()
                    .Include(domainModelContacts => domainModelContacts.Team).Include(domainModelContacts => domainModelContacts.Role).Include(DomainModelContacts => DomainModelContacts.Picture).ToList();
                return boardList;
            }
        }

        public DomainModelContacts Read(int Id)
        {
            DomainModelContacts contacts = null;
            using (var context = new Context.Context())
            {
                contacts =
                     context.Set<DomainModelContacts>()
                     .Include(domainModelContacts => domainModelContacts.Team).Include(domainModelContacts => domainModelContacts.Role).Include(domainModelContact => domainModelContact.Picture)
                     .Where(domainModelContacts => domainModelContacts.Id == Id).Single();
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
                    context.Set<DomainModelContacts>()
                    .Include(domainModelContacts => domainModelContacts.Team).Include(domianModelContact=> domianModelContact.Picture)
                    .Include(domainModelContacts => domainModelContacts.Role).Where(domainModelContacts => domainModelContacts.Id == Id).Single();
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
                    context.Set<DomainModelContacts>().Include(domainModelContacts => domainModelContacts.Team)
                        .Include(domainModelContacts => domainModelContacts.Role).Include(domainModelContacts => domainModelContacts.Picture)
                        .Where(domainModelContacts => domainModelContacts.Id == entity.Id)
                        .Single();

                if (contacts != null)
                {
                    contacts.FirstName = entity.FirstName;
                    contacts.LastName = entity.LastName;
                    contacts.Email = entity.Email;
                    contacts.Phone = entity.Phone;
                    
                }
                context.SaveChanges();
                return contacts;
            }
        }
    }
}
