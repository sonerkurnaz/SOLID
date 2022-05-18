using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.DataSourceSample.Bad
{
    internal class XMLSource : IOkuyab
    {
        public override void GetAll()
        {
            Console.WriteLine("XML GetAll..");
        }

        public override void Save()
        {
            Console.WriteLine("XML Save..");
        }
    }
}
