using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataAccessLayer.Repository
{
    public class TournamentRepository:ICrud<DomainModelTournament>
    {
        public List<DomainModelTournament> ReadAll()
        {
            using (var context = new Context.Context())
            {

                List<DomainModelTournament> tournamentList = context.Set<DomainModelTournament>().ToList();
                return tournamentList;
            }
        }

        public DomainModelTournament Read(int Id)
        {
            DomainModelTournament tournament = null;
            using (var context = new Context.Context())
            {
                tournament =
                     context.Set<DomainModelTournament>().Where(domainModelTournament => domainModelTournament.Id == Id).FirstOrDefault();
            }
            return tournament;
        }

        public void Create(DomainModelTournament entity)
        {
            using (var context = new Context.Context())
            {
                context.Set<DomainModelTournament>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var context = new Context.Context())
            {
                DomainModelTournament tournament =
                    context.Set<DomainModelTournament>().Where(domainModelTournament => domainModelTournament.Id == Id).FirstOrDefault();
                if (tournament != null)
                {
                    context.Set<DomainModelTournament>().Remove(tournament);
                }
                context.SaveChanges();
            }
        }

        public DomainModelTournament Update(DomainModelTournament entity)
        {
            using (var context = new Context.Context())
            {
                DomainModelTournament tournament =
                    context.Set<DomainModelTournament>()
                        .Where(domainModelTournament => domainModelTournament.Id == entity.Id)
                        .FirstOrDefault();
                if (tournament != null)
                {
                    tournament.Tournament = entity.Tournament;
                }
                context.SaveChanges();
                return tournament;
            }
        }
    }
}
