using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataAccessLayer.Repository
{
  public class TeamRepository:ICrud<DomainModelTeam>
    {
        public List<DomainModelTeam> ReadAll()
        {
            using (var context = new Context.Context())
            {
                List<DomainModelTeam> teamList = context.Set<DomainModelTeam>().ToList();
                return teamList;
            }
        }

        public DomainModelTeam Read(int Id)
        {

            DomainModelTeam team = null;
            using (var context = new Context.Context())
            {
                team =
                    context.Set<DomainModelTeam>().Where(domainModelTeam => domainModelTeam.Id == Id).FirstOrDefault();
            }
            return team;
        }

        public void Create(DomainModelTeam entity)
        {
            using (var context = new Context.Context())
            {
                context.Set<DomainModelTeam>().Add(entity);
                context.SaveChanges();
            }
        }

      public void Delete(int Id)
      {
          using (var context = new Context.Context())
          {
              DomainModelTeam team =
                  context.Set<DomainModelTeam>().Where(domainModelTeam => domainModelTeam.Id == Id).FirstOrDefault();
              if (team != null)
              {
                  context.Set<DomainModelTeam>().Remove(team);
              }
              context.SaveChanges();
          }
      }

      public DomainModelTeam Update(DomainModelTeam entity)
        {
            using (var context = new Context.Context())
            {
                DomainModelTeam team =
                    context.Set<DomainModelTeam>()
                        .Where(domainModelTeam => domainModelTeam.Id == entity.Id)
                        .FirstOrDefault();
                if (team != null)
                {
                    team.Team = entity.Team;
                }
                context.SaveChanges();
                return team;
            }
        }
    }
}
