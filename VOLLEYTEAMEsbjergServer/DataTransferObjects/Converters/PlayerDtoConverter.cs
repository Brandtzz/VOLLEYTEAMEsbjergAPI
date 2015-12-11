using DataAccessLayer.DomainModel;
using DataTransferObjects.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects.Converters
{
    public class PlayerDtoConverter : AbstractDtoConverter<DomainModelPlayer, PlayerDto>
    {
        public override PlayerDto Convert(DomainModelPlayer domainModelPlayer)
        {
            var dto = new PlayerDto()
            {
                Id = domainModelPlayer.Id,
                FirstName = domainModelPlayer.FirstName,
                LastName = domainModelPlayer.LastName,
                Address = domainModelPlayer.Address,
                Email = domainModelPlayer.Email,
                Phone = domainModelPlayer.Phone,
                Training = domainModelPlayer.Training,
                Games = domainModelPlayer.Games,
                PlayerOfTheMatch = domainModelPlayer.PlayerOfTheMatch,
                TeamId = domainModelPlayer.TeamId
            };
            return dto;
        }
    }
}
