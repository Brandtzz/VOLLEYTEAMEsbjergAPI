using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DomainModel
{
    public class DomainModelSponsor
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public int PictureId { get; set; }

        public string Name { get; set; }

        public List<DomainModelTeam> Team { get; set; }
    }
}
