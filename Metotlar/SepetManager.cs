using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urun.Adi);
        }


        public void Ekle2(string urunAdi, string aciklama, double fiyat,  int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }

    }
}
