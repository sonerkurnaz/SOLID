using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.DataSourceSample.Bad
{
    internal class ExcelDataSource : DataSource
    {
        public override void GetAll()
        {
            Console.WriteLine("Excel GetAll..");
        }

        public override void Save()
        {
            Console.WriteLine("Excel Save..");
        }
    }
}
