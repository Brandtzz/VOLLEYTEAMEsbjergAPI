using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DomainModel
{
    public class DomainModelPicture
    {
        public int Id { get; set; }
        public Image Picture { get; set; }
        public string PictureName { get; set; }
    }
}
