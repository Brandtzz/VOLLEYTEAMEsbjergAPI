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
    public class RoleApiController : ApiController
    {
        Facade facade = new Facade();

        // GET: api/RoleApi
        public IEnumerable<RoleDto> GetRoles()
        {
            var roles = new Facade().GetRoleRepository().ReadAll();
            return new RoleDtoConverter().Convert(roles);
        }

        // GET: api/RoleApi/5
        public RoleDto GetRole(int id)
        {
            var role = new Facade().GetRoleRepository().Read(id);
            return new RoleDtoConverter().Convert(role);
        }

        // POST: api/RoleApi
        public void PostRole(DomainModelRole domainModelRole)
        {
            new Facade().GetRoleRepository().Create(domainModelRole);    
        }

        // PUT: api/RoleApi/5
        public RoleDto PutRole(DomainModelRole domainModelRole)
        {
            var role = new Facade().GetRoleRepository().Update(domainModelRole);
            return new RoleDtoConverter().Convert(role);
        }

        // DELETE: api/RoleApi/5
        public void DeleteRole(int id)
        {
            new Facade().GetRoleRepository().Delete(id);
        }
    }
}
