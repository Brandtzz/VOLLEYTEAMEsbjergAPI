using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;
using DataTransferObjects.Converters;

namespace DataTransferObjects.DTO
{
    public class PictureDto
    {
        public int Id { get; set; }

        public Image Picture { get; set; }

        public string PictureName { get; set; }


    }
}
