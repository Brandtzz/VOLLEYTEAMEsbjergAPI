using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class DbInitializer
    {
        public static void Initialize()
        {
            Database.SetInitializer(new VolleyteamDbInitializer());
        }
    }
}
