using DataAccessLayer.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccessLayer.Repository
{
   public class PlayerRepository : ICrud<DomainModelPlayer>
    {


        public List<DomainModelPlayer> ReadAll()
        {
            using (var context = new Context.Context())
            {
                List<DomainModelPlayer> playerList = context.Set<DomainModelPlayer>()
                    .Include(domainModelPlayer => domainModelPlayer.Team).ToList();
                return playerList;
            }
        }

        public DomainModelPlayer Read(int Id)
        {
            DomainModelPlayer player = null;
            using (var context = new Context.Context())
            {
                player =
                    context.Set<DomainModelPlayer>().Include(domainModelPlayer => domainModelPlayer.Team)
                    .Where(domainModelPlayer => domainModelPlayer.Id == Id).Single();
            }
            return player;
        }


        public void Create(DomainModelPlayer entity)
        {
            using (var Context = new Context.Context())
            {
                Context.Set<DomainModelPlayer>().Add(entity);
                Context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var context = new Context.Context())
            {
                DomainModelPlayer player = context.Set<DomainModelPlayer>().Include(domainModelPlayer => domainModelPlayer.Team).Where(DomainModelPlayer => DomainModelPlayer.Id == Id).Single(); 
                if(player != null )
                {
                    context.Set<DomainModelPlayer>().Remove(player);
                }
                context.SaveChanges();
            }
        }

        public DomainModelPlayer Update(DomainModelPlayer entity)
        {
            using (var context = new Context.Context())
            {
                DomainModelPlayer player = context.Set<DomainModelPlayer>().Include(domainModelPlayer => domainModelPlayer.Team).
                    Where(DomainModelPlayer => DomainModelPlayer.Id == entity.Id)
                    .Single(); 
                if(player != null)
                {
                    player.FirstName = entity.FirstName;
                    player.LastName = entity.LastName;
                    player.Address = entity.Address;
                    player.Email = entity.Address;
                    player.Phone = entity.Phone;
                    player.TeamId = entity.TeamId;
                    player.Training = entity.Training;
                    player.Games = entity.Games;
                    player.PlayerOfTheMatch = entity.PlayerOfTheMatch;
                }
                context.SaveChanges();
                return player; 
            }
        }
    }
}
