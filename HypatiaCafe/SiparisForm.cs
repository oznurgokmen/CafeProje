using HypatiaCafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HypatiaCafe
{
    public partial class SiparisForm : Form
    {
        KafeDb db;

        Siparis siparis;

        BindingList<SiparisDetay> siparisDetaylarBL;

        //Hem KafeDb hem de Siparis nesnesi taşır.

        public SiparisForm(KafeDb kafeDb, Siparis siparis)
        {
            db = kafeDb;

            //Siparis türünden siparis nesnesini SiparisForm'un siparisi olarak atıyoruz, aynen kafeDb nesnesini db olarak atadığımız gibi bu forma ait yapıyoruz.

            this.siparis = siparis;

            siparisDetaylarBL = new BindingList<SiparisDetay>(siparis.SiparisDetaylar);

            InitializeComponent();

            dgvSiparisDetaylar.DataSource = siparisDetaylarBL;

            dgvSiparisDetaylar.Columns[0].Width = 100;
            dgvSiparisDetaylar.Columns[1].Width = 200;

            FiyatGuncelle();

            //SiparisForm'un texti

            Text = siparis.MasaNo + " Nolu Masa Sipariş Bilgileri (" + siparis.AcilisZamani + ")";

            UrunleriYukle();
        }

        //ComboBox'a Urunler'imizi bağladık, böylece güncel de kalıyor.
        
        private void UrunleriYukle()
        {
            cboUrunler.DataSource = db.Urunler;
        }

        //Hesap ve kalan bilgilerini hesaplayıp yazdıran metot.

        private void FiyatGuncelle()
        {
            lblToplamTutar.Text = string.Format("{0:0.00}₺", siparis.ToplamTutar());

            lblKalanTutar.Text = string.Format("{0:0.00}₺", siparis.KalanTutar());
        }

        //SiparisForm'u kapatıp masa forma döner.

        private void btnAnasayfayaDön_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Bu buton benim ara ödeme için eklediğim buton, hesabı kapatmaz.

        private void btnHesabiBeklet_Click(object sender, EventArgs e)
        {
            try
            {
                siparis.AraOdeme = Convert.ToDecimal(txtOdenenTutar.Text);

                siparis.OdenenTutar += siparis.AraOdeme;

                siparis.AraOdeme = siparis.OdenenTutar;

                siparis.Durum = SiparisDurum.Aktif;

                FiyatGuncelle();

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız ! Lütfen Geçerli Bir Tutar Giriniz !");
            }
        }

        //Masanın ödemesi alındığında hesabı kapatan buton.Textbox'a girilen tutara ve önceki ara ödemelere(varsa) göre kapatıyor, direk kapatmaz.

        private void btnHesabiKapat_Click(object sender, EventArgs e)
        {
            try
            {
                siparis.ToplamHesap = siparis.ToplamTutar();

                siparis.OdenenTutar = Convert.ToDecimal(txtOdenenTutar.Text) + siparis.AraOdeme;

                if (siparis.OdenenTutar >= siparis.ToplamHesap)
                {
                    decimal bahsis = siparis.OdenenTutar - siparis.ToplamHesap;

                    if (bahsis == 0)
                    {
                        MessageBox.Show("Para Üstü Yoktur.");
                    }
                    else
                    {
                        MessageBox.Show("Para Üstü: " + bahsis + " ₺"+ "\nPara Üstünden Kalanı TipBox'a Atmayı Unutmayınız !");
                    }

                    siparis.Durum = SiparisDurum.Odendi;

                    siparis.KapanisZamani = DateTime.Now;

                    Close();
                }

                else
                {
                    MessageBox.Show("Girilen Tutar Hesabı Kapatmak İçin Yetersizdir !");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız ! Lütfen Geçerli Bir Tutar Giriniz !");
            }
                          
        }

        //Kullanıcı yanlışlıkla masa açtığında ya da müşteri vazgeçtiğinde bu buton masayı kapatmak için kullanır. Benim projemde ödenen tutar toplam hesaptan düşükse ve hesap kapatılmak isteniyorsa da durum ödendi olarak değil iptal olarak giriliyor, bu buton kullanılıyor.

        private void btnMasayiIptalEt_Click(object sender, EventArgs e)
        {
            siparis.Durum = SiparisDurum.Iptal;

            siparis.KapanisZamani = DateTime.Now;

            Close();          
        }

        //Masadan verilen siparişin detaylarını listeye ekler.

        private void btnSiparisDetayEkle_Click(object sender, EventArgs e)
        {
            SiparisDetay sd = new SiparisDetay
            {
                Urun = (Urun)cboUrunler.SelectedItem,

                Adet = (int)nudAdet.Value
            };

            siparisDetaylarBL.Add(sd);

            FiyatGuncelle();
        }

      
    }
}
