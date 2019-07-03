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
    public partial class UrunlerForm : Form
    {
        KafeDb db;

        //dgvUrunler de kullanıcının yaptığı değişikliklerin (ekleme vs) Urunler listemizde de güncel olması için BindingList kullandık.

        BindingList<Urun> urunlerBL;

        public UrunlerForm(KafeDb kafeDb)
        {
            db = kafeDb;

            urunlerBL = new BindingList<Urun>(db.Urunler);

            InitializeComponent();

            dgvUrunler.DataSource = urunlerBL;

            dgvUrunler.Columns[0].Width = 130;
            dgvUrunler.Columns[1].Width = 110;
        }
    }
}
