using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Helpers;

namespace DataAccessLayer.DomainModel
{
    public class DomainModelPicture
    {
        public int Id { get; set; }
        public byte[] Picture { get; set; }
        public string PictureName { get; set; }

        public DomainModelSponsor SponsorId { get; set; }
        public DomainModelContacts ContactId { get; set; }
    }
}
