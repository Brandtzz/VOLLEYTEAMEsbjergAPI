using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DomainModel
{
   public class DomainModelRole
    {
        public int Id { get; set; }

        public string Role { get; set; }

        public List<DomainModelContacts> Contacts { get; set; }

    }
}
