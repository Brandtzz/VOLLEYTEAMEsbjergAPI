using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DomainModel
{
    public class DomainModelTeam
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Intro { get; set; }

        public List<DomainModelContacts> Contacts { get; set; }

        public List<DomainModelSponsor> Sponsor { get; set; }

        public List<DomainModelPlayer> Player { get; set; }

    }
}
