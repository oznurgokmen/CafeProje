using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypatiaCafe.Models
{
    //Kaydedilmesi gereken bütün bilgileri KafeDb class'ımız taşıyor (bizim veritabanımız gibi oluyor).

    public class KafeDb
    {
        //Constructor'da ürünler, aktif ve geçmiş siparişleri atacağımız listeleri oluşturuyoruz.

        public KafeDb()
        {
            Urunler = new List<Urun>();
            AktifSiparisler = new List<Siparis>();
            GecmisSiparisler = new List<Siparis>();
        }

        //Listelerimizin her birinden KafeDb için property oluşturuyoruz.

        public List<Urun> Urunler { get; set; }

        public List<Siparis> AktifSiparisler { get; set; }

        public List<Siparis> GecmisSiparisler { get; set; }
    }
}
