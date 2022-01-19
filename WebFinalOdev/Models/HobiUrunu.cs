using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFinalOdev.Models
{
    public class HobiUrunu
    {
        public int SiraNo { get; set; }
        public string UrunAdi { get; set; }
        public string UreticiAdi { get; set; }
        public string UrunTuru { get; set; }
        public int UretimYili { get; set; }
        public int Fiyat { get; set; }
    }
}
