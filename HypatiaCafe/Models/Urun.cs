using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypatiaCafe.Models
{
    //Kafemizde bulunan bir ürünün adını ve fiyatını Urun class'ımız taşır. 

    public class Urun
    {
        public string UrunAd { get; set; }

        public decimal BirimFiyat { get; set; }
      
        //Ürün bilgisini yazdırırken/eklerken string formatına dönüştürüyoruz.

        public override string ToString()
        {
            return string.Format("{0} - {1:0.00}₺", UrunAd, BirimFiyat);
        }
    }
}
