using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypatiaCafe.Models
{
    //Bir masadan verilen sipariş için sadece bir çeşit ürünü ve adet bilgisini SiparisDetay class'ımız taşır. Verilen siparişte birden çok sipariş detayı olabilir, farklı ürünler sipariş edilirse.

    public class SiparisDetay
    {
        public int Adet { get; set; }

        public Urun Urun { get; set; }

        //Sipariş verilen bir ürün için kaç adetse tutarı hesaplar, her sipariş edilen ürün için ayrı ayrı hesaplar ve bu bilgiyi döndürür.

        public decimal Tutar()
        {
            return Urun.BirimFiyat * Adet;
        }
    }
}
