using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.PictureConverter
{
    public class PictureConverter
    {
        public byte[] TransformImage(byte[] imageData)
        {
            using (var input = new MemoryStream(imageData))
            {
                using (Image img = Image.FromStream(input))
                {
                    // perform your transformations

                    using (var output = new MemoryStream())
                    {
                        img.Save(output, ImageFormat.Bmp);

                        return output.ToArray();
                    }
                }
            }
        }
    }
}
