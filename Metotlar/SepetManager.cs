using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {

        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler :) Sepete Eklendi!!!! : " + urun.urunAdi);
        }

        public void Ekle2(string urunAdi, string aciklamasi, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler :) Sepete Eklendi!!!! : " + urunAdi);
        }
                

    }
}
