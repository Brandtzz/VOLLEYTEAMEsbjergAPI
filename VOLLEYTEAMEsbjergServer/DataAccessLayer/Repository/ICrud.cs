using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
   public interface ICrud<Entity>
   {

       List<Entity> ReadAll();
       Entity Read(int Id);
       void Create(Entity entity);
       void Delete(int Id);
       Entity Update(Entity entity);

   }
}
