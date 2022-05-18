using LSP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.GoodExample.Concrete
{
    internal class Dikdortgen : Sekil
    {
        public int UzunKenar { get; set; }

        public override int AlanHesapla()
        {
            return Kenar + UzunKenar; 
        }
    }
}
