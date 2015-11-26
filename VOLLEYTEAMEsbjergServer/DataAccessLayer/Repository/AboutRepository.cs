using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataAccessLayer.Repository
{
    public class AboutRepository : ICrud<DomainModelAbout>
    {
        public List<DomainModelAbout> ReadAll()
        {
            using (var context = new Context.Context())
            {
                List<DomainModelAbout> aboutList = context.Set<DomainModelAbout>().ToList();
                return aboutList;
            }
        }

        public DomainModelAbout Read(int Id)
        {
            DomainModelAbout about = null;
            using (var context = new Context.Context())
            {
                about =
                    context.Set<DomainModelAbout>().Where(domainModelAbout => domainModelAbout.Id == Id).FirstOrDefault();
            }
            return about;
        }

        public void Create(DomainModelAbout entity)
        {
            using (var context = new Context.Context())
            {
                context.Set<DomainModelAbout>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var context = new Context.Context())
            {
                DomainModelAbout about =
                    context.Set<DomainModelAbout>().Where(domainModelAbout => domainModelAbout.Id == Id).FirstOrDefault();
                if (about != null)
                {
                    context.Set<DomainModelAbout>().Remove(about);
                }
                context.SaveChanges();
            }
        }

        public DomainModelAbout Update(DomainModelAbout entity)
        {
            using (var context = new Context.Context())
            {
                DomainModelAbout about =
                    context.Set<DomainModelAbout>()
                        .Where(domainModelAbout => domainModelAbout.Id == entity.Id)
                        .FirstOrDefault();
                if (about != null)
                {
                    about.About = entity.About;
                }
                context.SaveChanges();
                return about;
            }
        }
    }
}
