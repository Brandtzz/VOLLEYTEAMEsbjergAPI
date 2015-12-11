using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DomainModel
{
   public class DomainModelContacts
    {
       public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int PictureId { get; set; }

        public List<DomainModelTeam> Team { get; set; }

        public List<DomainModelRole> Role { get; set; }


    }
}
