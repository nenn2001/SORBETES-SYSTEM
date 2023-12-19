using Dbsys.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbsys.Repository
{
    internal class SalesRepository
    {
        private DBSYSEntities1 db;

        public SalesRepository()
        {
            db = new DBSYSEntities1();
        }

        
    }
}
