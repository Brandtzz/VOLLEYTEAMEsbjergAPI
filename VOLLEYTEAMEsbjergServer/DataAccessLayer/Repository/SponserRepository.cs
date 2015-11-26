using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataAccessLayer.Repository
{
    public class SponserRepository:ICrud<DomainModelSponsor>
    {
        public List<DomainModelSponsor> ReadAll()
        {
            using (var context = new Context.Context())
            {

                List<DomainModelSponsor> sponsorList = context.Set<DomainModelSponsor>().ToList();
                return sponsorList;
            }
        }

        public DomainModelSponsor Read(int Id)
        {
            DomainModelSponsor sponsor = null;
            using (var context = new Context.Context())
            {
                sponsor =
                     context.Set<DomainModelSponsor>().Where(domainModelSponsor => domainModelSponsor.Id == Id).FirstOrDefault();
            }
            return sponsor;
        }

        public void Create(DomainModelSponsor entity)
        {
            using (var context = new Context.Context())
            {
                context.Set<DomainModelSponsor>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var context = new Context.Context())
            {
                DomainModelSponsor sponsor =
                    context.Set<DomainModelSponsor>().Where(domainModelSponsor => domainModelSponsor.Id == Id).FirstOrDefault();
                if (sponsor != null)
                {
                    context.Set<DomainModelSponsor>().Remove(sponsor);
                }
                context.SaveChanges();
            }
        }

        public DomainModelSponsor Update(DomainModelSponsor entity)
        {
            using (var context = new Context.Context())
            {
                DomainModelSponsor sponsor =
                    context.Set<DomainModelSponsor>()
                        .Where(domainModelSponsor => domainModelSponsor.Id == entity.Id)
                        .FirstOrDefault();
                if (sponsor != null)
                {
                    sponsor.Sponsor= entity.Sponsor;
                }
                context.SaveChanges();
                return sponsor;
            }
        }
    }
}
