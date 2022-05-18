using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.BadExample
{
    internal class AlanHesaplayıcı
    {
        public int AlanHesapla(Dikdörtgen dikdörtgen)
        {
            return dikdörtgen.KisaKenar * dikdörtgen.UzunKenar;
        }
        public int AlanHesapla(Kare kare)
        {
            return kare.KisaKenar * kare.UzunKenar;
        }
    }
}
