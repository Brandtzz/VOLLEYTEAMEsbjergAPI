using DataAccessLayer.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
   public class EnglishRepository : ICrud<DomainModelEnglish>
    {

        public List<DomainModelEnglish> ReadAll()
        {
            using (var context = new Context.Context())
            {
                List<DomainModelEnglish> englishList = context.Set<DomainModelEnglish>().ToList();
                return englishList;
            }
        }

        public DomainModelEnglish Read(int Id)
        {
            DomainModelEnglish english = null;
            using (var context = new Context.Context())
            {
                english =
                    context.Set<DomainModelEnglish>().Where(DomainModelEnglish => DomainModelEnglish.Id == Id).FirstOrDefault(); 
            }
            return english; 
        }

        public void Create(DomainModelEnglish entity)
        {
            using (var context = new Context.Context())
            {
                context.Set<DomainModelEnglish>().Add(entity);
                context.SaveChanges(); 
            }
        }

        public void Delete(int Id)
        {
            using (var context = new Context.Context())
            {
                DomainModelEnglish english =
                    context.Set<DomainModelEnglish>().Where(DomainModelEnglish => DomainModelEnglish.Id == Id).FirstOrDefault();
                if(english != null)
                {
                    context.Set<DomainModelEnglish>().Remove(english);
                }
            }
        }




        public DomainModelEnglish Update(DomainModelEnglish entity)
        {
            using (var context = new Context.Context())
            {
                DomainModelEnglish english =
                    context.Set<DomainModelEnglish>()
                    .Where(DomainModelEnglish => DomainModelEnglish.Id == entity.Id)
                    .FirstOrDefault(); 
                if(english != null)
                {
                    english.English = entity.English; 
                }
                context.SaveChanges();
                return english; 
            }
        }
    }
}
