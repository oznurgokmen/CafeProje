using HypatiaCafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HypatiaCafe
{
    public partial class Form1 : Form
    {
        KafeDb db;

        int masaAdet = 20;

        public Form1()
        {
            //Projeye başlayınca VerileriOkuXML metodunu henüz yazmadığımız için ürünleri OrnekVerileriYukle metoduyla eklemiştik.Sonradan gerek kalmadığı için yoruma aldık.

            //OrnekUrunleriYukle(db);

            VerileriOkuXML();

            //db = new KafeDb();

            InitializeComponent();

            MasalariYukle();          
        }
       
        //Kayıtlı verimiz yokken kullandığımız, ürün eklediğimiz metot.

        private void OrnekUrunleriYukle(KafeDb kafeDb)
        {           
                kafeDb.Urunler.Add(new Urun { UrunAd = "Kola", BirimFiyat = 5m });

                kafeDb.Urunler.Add(new Urun { UrunAd = "Su", BirimFiyat = 2m });

                kafeDb.Urunler.Add(new Urun { UrunAd = "Ayran", BirimFiyat = 4m });

                kafeDb.Urunler.Add(new Urun { UrunAd = "Hamburger", BirimFiyat = 26m });

                kafeDb.Urunler.Add(new Urun { UrunAd = "Salata", BirimFiyat = 15m });

                kafeDb.Urunler.Add(new Urun { UrunAd = "Profiterol", BirimFiyat = 9m });             
        }

        //Bu metodu masalarımızı ListView de göstermek için yazdık.

        private void MasalariYukle()
        {
            // Masa resimlerini atmak için ImageList oluşturduk.Zaten iki resmimiz var ve bunları "bos" ve "dolu" olarak işaretleyip(ImageKey) Resources'da hangi resim olduğunu söyleyip listeye ekliyoruz.Resimlerin boyutlarını ImageSize'la belirliyoruz.Form'a koyduğumuz ListView (lwvMasalar)'in large icon özelliğiyle listemiz "ilist" i lvwMasalara eklemiş olduk.

            ImageList ilist = new ImageList();
            
            ilist.Images.Add("bos", Properties.Resources.bos);

            ilist.Images.Add("dolu", Properties.Resources.dolu);

            ilist.ImageSize = new Size(64, 64);

            lvwMasalar.LargeImageList = ilist;

            ListViewItem lvi;

            //Toplamda 20 adet masamız var.Ve her masayı ListView'e nasıl göstereceğini (dolu mu boş mu) MasaAcikMi metotoduyla söylüyoruz.Ve masa numarası için Tag özelliği ile etiketliyoruz.

            for (int masaNo = 1; masaNo <= masaAdet; masaNo++)
            {
                lvi = new ListViewItem("Masa " + masaNo);

                lvi.Tag = masaNo;

                lvi.ImageKey = MasaAcikMi(masaNo) ? "dolu" : "bos";

                lvwMasalar.Items.Add(lvi);
            }

        }

        //Bu metodu MasalariYukle metodunda hangi resmi kullanacağını anlaması için yazdık.AktifSiparisleri her MasaNo için geziyoruz ve yukarda tek tek içine attığımız masaNo ile uyuşuyorsa true, uyuşmuyorsa false gönderiyor, böylece hangi resmi göstereceğini söylemiş oluyoruz.

        private bool MasaAcikMi(int masaNo)
        {
            foreach (Siparis s in db.AktifSiparisler)
            {
                if (s.MasaNo == masaNo)
                {
                    return true;
                }
            }

            return false;
        }

        //Önce Aktifsiparisleri tek tek geziyoruz, eğer bu masaNo ile sipariş kaydı varsa siparişi SiparisGetir metoduyla gönderiyoruz.Eğer sipariş kaydı bulamadıysa yeni sipariş oluşturuyoruz ve AktifSiparisler'e ekliyoruz.Sonra bu eklediğimiz siparişi gönderiyoruz.

        private Siparis SiparisGetir(int masaNo)
        {          
            foreach (Siparis s in db.AktifSiparisler)
            {
                if (s.MasaNo == masaNo)
                {
                    return s;
                }
            }
         
            Siparis siparis = new Siparis
            {
                MasaNo = masaNo,
                AcilisZamani = DateTime.Now,
                Durum = SiparisDurum.Aktif,
            };

            db.AktifSiparisler.Add(siparis);

            return siparis;         
        }

        //Masa açmak için ListView'in double-click eventini kullandık.

        private void lvwMasalar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Çift tıklanılan masanın numarasını (tag) listview'in seçili eleman özelliğinden alıyoruz, etiketini(ImageKey) "dolu" yapıyoruz, tag ile aldığımız masa numarasını SiparisGetir metoduna veriyoruz, SiparisForm'u açıyoruz.SiparisForm'dan gelen işlem sonucu ödendi ya da iptal ise etiketi tekrar "bos" a çeviriyoruz.Siparişi AktifSiparis'ten çıkarıp GecmisSiparisler'e ekliyoruz.

            ListViewItem lviSeciliMasa = lvwMasalar.SelectedItems[0];

            lviSeciliMasa.ImageKey = "dolu";

            int seciliMasaNo = (int)lviSeciliMasa.Tag;

            Siparis siparis = SiparisGetir(seciliMasaNo);

            SiparisForm siparisForm = new SiparisForm(db, siparis);

            siparisForm.ShowDialog();

            if (siparis.Durum == SiparisDurum.Odendi || siparis.Durum == SiparisDurum.Iptal)
            {
                lviSeciliMasa.ImageKey = "bos";

                siparis.KapanisZamani = DateTime.Now;

                db.AktifSiparisler.Remove(siparis);

                db.GecmisSiparisler.Add(siparis);
            }         

        }

        //MenuStrip'de Ürünler seçildiyse UrunlerForm'u açar.

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            UrunlerForm frmUrunler = new UrunlerForm(db);

            frmUrunler.ShowDialog();
        }

        //MenuStrip'de GecmisSiparisler seçildiyse GecmisSiparislerForm'u açar.

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            GecmisSiparislerForm frmGecmisSiparisler = new GecmisSiparislerForm(db);

            frmGecmisSiparisler.ShowDialog();
        }

        //Db nesnemizi veri.xml dosyasından okuyarak oluşturur.Bunun için projemize System.Xml.Serialization ve System.IO kütüphanelerini dahil ettik.Eğer veri.xml oluşamazsa hata almamak için try-catch yaptık, yoksa db nesnemizi oluşturuyoruz.

        private void VerileriOkuXML()
        {
            // Serialization(Serileştirme) işlemi uyguluyoruz.XmlSerializer nesnemizin (db) bir kopyasını kullanarak kolay erişilebilir bir formata çevirir ve durumunu korur.Nesnemizi orjinal haline getirme işlemi ise Deserialize'dir.FileStream ise belirtilen dosya üstünden okuma, yazma yapar.

            try
            {
                //Nesnemizin türü KafeDb.

                XmlSerializer ser = new XmlSerializer(typeof(KafeDb));

                FileStream fs = new FileStream("veri.xml", FileMode.Open);

                db = (KafeDb)ser.Deserialize(fs);

                fs.Close();
            }
            catch (Exception)
            {
                db = new KafeDb();
            }
        }

        //Ana Sayfa'mızı (Form) kapatırken verilerimizi kaydediyoruz.

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydetXML();
        }

        // Db nesnemizi xml olarak kaydetmek için yazdık.StreamWriter ise verilerimizi dosyamıza yazar.

        private void VerileriKaydetXML()
        {
            XmlSerializer ser = new XmlSerializer(typeof(KafeDb));

            StreamWriter sw = new StreamWriter("veri.xml");

            ser.Serialize(sw, db);

            sw.Close();
        }
    }
}
