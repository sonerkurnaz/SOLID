using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.DataSourceSample.Bad
{
    internal abstract class DataSource
    {
        public abstract void GetAll();
        public abstract void Save();
    }
}
