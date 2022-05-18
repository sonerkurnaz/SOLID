using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.BadExample
{
    internal class Kare : Dikdörtgen
    {
        private int _KisaKenar;

        public int KisaKenar
        {
            get { return _KisaKenar; }
            set { _KisaKenar = value; }
        }
        private int _UzunKenar;

        public int UzunKenar
        {
            get { return _UzunKenar; }
            set { _UzunKenar = value; }
        }


    }
}
