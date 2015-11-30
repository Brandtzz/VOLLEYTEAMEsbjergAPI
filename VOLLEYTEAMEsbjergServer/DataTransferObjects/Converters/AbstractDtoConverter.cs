using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects.Converters
{
    public abstract class AbstractDtoConverter<domainModel, dataTransferObject>
    {
        public IEnumerable<dataTransferObject> Convert(IEnumerable<domainModel> toConvert)
        {
            List<dataTransferObject> converted = new List<dataTransferObject>();
            foreach (var item in toConvert)
            {
                converted.Add(Convert(item));
            }
            return converted;
        }

        public abstract dataTransferObject Convert(domainModel item);
    }
}
