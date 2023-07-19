using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Urun
    {

        //Property -- özellikleri
        //encapsulation

        public int Id { get; set; }
        public string urunAdi { get; set; }
        public double fiyati { get; set; }
        public string aciklamasi { get; set; }
        public int stokAdedi { get; set; }
    }
}
