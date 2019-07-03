using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypatiaCafe.Models
{
    //Masa açıkken/açılırken müşterilerin verdiği tüm sipariş istekleriyle ilgili bilgileri ve hesap bilgilerini Siparis class'ımız taşır.

    //Zaten kısıtlı ve sabit sayıda masa durumu olacağı için enum kullanmayı tercih ettik.

    public enum SiparisDurum { Aktif = 1, Odendi = 2, Iptal = 9 }

    public class Siparis
    {
        //Constructor'ın da sipariş detaylarımızı taşıyacak listemizi oluşturuyoruz.

        public Siparis()
        {
            SiparisDetaylar = new List<SiparisDetay>();
        }

        public int MasaNo { get; set; }

        public decimal ToplamHesap { get; set; }

        public decimal AraOdeme { get; set; }

        public decimal OdenenTutar { get; set; }

        public DateTime? AcilisZamani { get; set; }

        public DateTime? KapanisZamani { get; set; }

        public SiparisDurum Durum { get; set; }

        public List<SiparisDetay> SiparisDetaylar { get; set; }

        //Hesabı hesaplayıp döndürmek için bu metodu yazıyoruz, zaten SiparisDetay class'ımızda her bir sipariş detayı için Tutar metodu yazmıştık, ToplamTutar'da da bunları topluyoruz.

        public decimal ToplamTutar()
        {
            decimal toplam = 0;

            foreach (SiparisDetay sd in SiparisDetaylar)
            {
                toplam += sd.Tutar();
            }

            return toplam;
        }

        //Eğer müşterilerden erken kalkıp kendi hesabını ödemek isteyen olursa diye oluşturduğum OdenenTutar'ı ToplamTutar'dan çıkararak SiparisForm'da FiyatGuncelle metodunun içinde bu metotla lblKalanTutar'a aktardım.

        public decimal KalanTutar()
        {
            decimal kalan = ToplamTutar() - OdenenTutar;         

            return kalan;
        }
    }
}
