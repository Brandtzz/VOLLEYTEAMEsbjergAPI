using DataAccessLayer;
using DataAccessLayer.DomainModel;
using DataTransferObjects.Converters;
using DataTransferObjects.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rest_Api.Controllers
{
    public class PlayerApiController : ApiController
    {

        Facade facade = new Facade();
        // GET: api/Player
        public IEnumerable<PlayerDto> GetPlayers()
        {
            var players = new Facade().GetPlayerRepository().ReadAll();
            return new PlayerDtoConverter().Convert(players); 
        }

        // GET: api/Player/5
        public PlayerDto GetPlayer(int id)
        {
            var player = new Facade().GetPlayerRepository().Read(id);
            return new PlayerDtoConverter().Convert(player);
        }

        // POST: api/Player
        public void PostPlayer(DomainModelPlayer domainModelPlayer)
        {
            new Facade().GetPlayerRepository().Create(domainModelPlayer);
        }

        // PUT: api/Player/5
        public PlayerDto PutPlayer(DomainModelPlayer domainModelPlayer)
        {
            var player = new Facade().GetPlayerRepository().Update(domainModelPlayer);
            return new PlayerDtoConverter().Convert(player);
        }

        // DELETE: api/Player/5
        public void DeletePlayer(int id)
        {
            new Facade().GetPlayerRepository().Delete(id);
        }
    }
}
