using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.DataSourceSample.Bad
{
    internal class DataSourceProcess
    {
        public void SaveAll(List<DataSource> sourceList)
        {
            foreach (var item in sourceList)
            {
                item.Save();
            }
        }
    }
}
