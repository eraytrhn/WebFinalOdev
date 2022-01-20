using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFinalOdev.Models
{
    public class HobiUrunuVeri
    {
        public static List<HobiUrunu> HobiUrunuleri = new List<HobiUrunu>() 
        {
            new HobiUrunu()
                        {
                            SiraNo = 1,
                            UrunAdi = "Dark Souls",
                            UreticiAdi = "FromSoftware, Bandai Namco,",
                            UrunTuru = "Souls-like, JRPG",
                            UretimYili =2011,
                            Fiyat =119
                        },
            new HobiUrunu()
                        {
                            SiraNo = 2,
                            UrunAdi = "Dark Souls 2",
                            UreticiAdi = "FromSoftware, Bandai Namco,",
                            UrunTuru = "Souls-like, JRPG",
                            UretimYili =2014,
                            Fiyat =119
                        },
            new HobiUrunu()
                        {
                            SiraNo = 3,
                            UrunAdi = "Dark Souls 3",
                            UreticiAdi = "FromSoftware, Bandai Namco,",
                            UrunTuru = "Souls-like, JRPG",
                            UretimYili =2016,
                            Fiyat =179
                        },
        };
    }
}
