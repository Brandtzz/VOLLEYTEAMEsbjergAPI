using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects.Converters
{
    public class SponsorDto
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public int TeamId { get; set; }

        public int PictureId { get; set; }

        public string Name { get; set; }
    }
}
