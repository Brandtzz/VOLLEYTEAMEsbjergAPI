using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataAccessLayer.Repository
{
    public class RoleRepository:ICrud<DomainModelRole>
    {
        public List<DomainModelRole> ReadAll()
        {
            using (var context = new Context.Context())
            {
                List<DomainModelRole> roleList = context.Set<DomainModelRole>().ToList();
                return roleList;
            }
        }

        public DomainModelRole Read(int Id)
        {
            DomainModelRole role = null;
            using (var context = new Context.Context())
            {
                role =
                    context.Set<DomainModelRole>().Where(domainModelRole => domainModelRole.Id == Id).FirstOrDefault();
            }
            return role;
        }

        public void Create(DomainModelRole entity)
        {
            using (var context = new Context.Context())
            {
                context.Set<DomainModelRole>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var context = new Context.Context())
            {
                DomainModelRole role =
                    context.Set<DomainModelRole>().Where(domainModelRole => domainModelRole.Id == Id).FirstOrDefault();
                if (role != null)
                {
                    context.Set<DomainModelRole>().Remove(role);
                }
                context.SaveChanges();
            }
        }

        public DomainModelRole Update(DomainModelRole entity)
        {
            using (var context = new Context.Context())
            {
                DomainModelRole role =
                    context.Set<DomainModelRole>()
                        .Where(domainModelRole => domainModelRole.Id == entity.Id)
                        .FirstOrDefault();
                if (role != null)
                {
                    role.Role = entity.Role;
                }
                context.SaveChanges();
                return role;
            }
        }
    }
}
