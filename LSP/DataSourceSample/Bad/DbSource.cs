using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.DataSourceSample.Bad
{
    internal class DbSource : DataSource
    {
        public override void GetAll()
        {
            Console.WriteLine("Database GetAll..");
        }

        public override void Save()
        {
            Console.WriteLine("Database Save..");
        }
    }
}
