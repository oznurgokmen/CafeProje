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
    public partial class GecmisSiparislerForm : Form
    {
        KafeDb db;

        //Gecmiş siparişlerimiz için oluşturduk.

        public GecmisSiparislerForm(KafeDb kafeDb)
        {
            db = kafeDb;

            InitializeComponent();

            dgvGecmisSiparisler.DataSource = db.GecmisSiparisler;

            dgvGecmisSiparisler.Columns[4].Width = 130;
            dgvGecmisSiparisler.Columns[5].Width = 130;
        }
    }
}
