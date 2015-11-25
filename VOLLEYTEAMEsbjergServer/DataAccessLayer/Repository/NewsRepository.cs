using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataAccessLayer.Repository
{
    class NewsRepository:ICrud<DomainModelNews>

    {
        public List<DomainModelNews> ReadAll()
        {
            using (var context = new Context.Context())
            {
                List<DomainModelNews> newsList = context.Set<DomainModelNews>().ToList();
                return newsList;
            }

            
        }

        public DomainModelNews Read(int Id)
        {
            DomainModelNews news = null;
            using (var context = new Context.Context())
            {
                news =
                    context.Set<DomainModelNews>().Where(domainModelNews => domainModelNews.Id == Id).FirstOrDefault();
            }
            return news;
        }

        public void Create(DomainModelNews entity)
        {
            using (var context = new Context.Context())
            {
                context.Set<DomainModelNews>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var context = new Context.Context())
            {
                DomainModelNews news =
                    context.Set<DomainModelNews>().Where(domainModelNews => domainModelNews.Id == Id).FirstOrDefault();
                if (news != null)
                {
                    context.Set<DomainModelNews>().Remove(news);
                }
                context.SaveChanges();
            }
        }

        public DomainModelNews Update(DomainModelNews entity)
        {
            using (var context = new Context.Context())
            {
                DomainModelNews news =
                    context.Set<DomainModelNews>()
                        .Where(domainModelNews => domainModelNews.Id == entity.Id)
                        .FirstOrDefault();
                if (news != null)
                {
                    news.News = entity.News;
                }
                context.SaveChanges();
                return news;
            }
        }
    }
}
