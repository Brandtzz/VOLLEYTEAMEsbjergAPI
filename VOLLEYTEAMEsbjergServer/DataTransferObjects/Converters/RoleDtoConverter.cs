using DataAccessLayer.DomainModel;
using DataTransferObjects.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects.Converters
{
    public class RoleDtoConverter : AbstractDtoConverter<DomainModelRole, RoleDto>
    {
        public override RoleDto Convert(DomainModelRole domainModelRole)
        {
            var dto = new RoleDto()
            {
                Id = domainModelRole.Id,
                Role = domainModelRole.Role
            };
            return dto; 
        }
    }
}
