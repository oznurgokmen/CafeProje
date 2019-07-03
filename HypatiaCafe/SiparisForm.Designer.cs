namespace HypatiaCafe
{
    partial class SiparisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSiparisDetaylar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisDetayEkle = new System.Windows.Forms.Button();
            this.btnHesabiKapat = new System.Windows.Forms.Button();
            this.btnMasayiIptalEt = new System.Windows.Forms.Button();
            this.btnAnasayfayaDön = new System.Windows.Forms.Button();
            this.cboUrunler = new System.Windows.Forms.ComboBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.lblKalanTutar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOdenenTutar = new System.Windows.Forms.TextBox();
            this.btnHesabiBeklet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisDetaylar
            // 
            this.dgvSiparisDetaylar.AllowUserToAddRows = false;
            this.dgvSiparisDetaylar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSiparisDetaylar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylar.Location = new System.Drawing.Point(12, 94);
            this.dgvSiparisDetaylar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            this.dgvSiparisDetaylar.ReadOnly = true;
            this.dgvSiparisDetaylar.RowTemplate.Height = 24;
            this.dgvSiparisDetaylar.Size = new System.Drawing.Size(341, 433);
            this.dgvSiparisDetaylar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Toplam Tutar:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToplamTutar.Location = new System.Drawing.Point(548, 102);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(101, 35);
            this.lblToplamTutar.TabIndex = 4;
            this.lblToplamTutar.Text = "00,00₺";
            // 
            // btnSiparisDetayEkle
            // 
            this.btnSiparisDetayEkle.Location = new System.Drawing.Point(395, 43);
            this.btnSiparisDetayEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSiparisDetayEkle.Name = "btnSiparisDetayEkle";
            this.btnSiparisDetayEkle.Size = new System.Drawing.Size(228, 46);
            this.btnSiparisDetayEkle.TabIndex = 5;
            this.btnSiparisDetayEkle.Text = "Sipariş Detay Ekle";
            this.btnSiparisDetayEkle.UseVisualStyleBackColor = true;
            this.btnSiparisDetayEkle.Click += new System.EventHandler(this.btnSiparisDetayEkle_Click);
            // 
            // btnHesabiKapat
            // 
            this.btnHesabiKapat.Location = new System.Drawing.Point(395, 348);
            this.btnHesabiKapat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHesabiKapat.Name = "btnHesabiKapat";
            this.btnHesabiKapat.Size = new System.Drawing.Size(228, 52);
            this.btnHesabiKapat.TabIndex = 6;
            this.btnHesabiKapat.Text = "Ödeme Alındı Hesabı Kapat";
            this.btnHesabiKapat.UseVisualStyleBackColor = true;
            this.btnHesabiKapat.Click += new System.EventHandler(this.btnHesabiKapat_Click);
            // 
            // btnMasayiIptalEt
            // 
            this.btnMasayiIptalEt.Location = new System.Drawing.Point(395, 408);
            this.btnMasayiIptalEt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMasayiIptalEt.Name = "btnMasayiIptalEt";
            this.btnMasayiIptalEt.Size = new System.Drawing.Size(228, 50);
            this.btnMasayiIptalEt.TabIndex = 7;
            this.btnMasayiIptalEt.Text = "Masayı İptal Et";
            this.btnMasayiIptalEt.UseVisualStyleBackColor = true;
            this.btnMasayiIptalEt.Click += new System.EventHandler(this.btnMasayiIptalEt_Click);
            // 
            // btnAnasayfayaDön
            // 
            this.btnAnasayfayaDön.Location = new System.Drawing.Point(395, 466);
            this.btnAnasayfayaDön.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnasayfayaDön.Name = "btnAnasayfayaDön";
            this.btnAnasayfayaDön.Size = new System.Drawing.Size(228, 55);
            this.btnAnasayfayaDön.TabIndex = 8;
            this.btnAnasayfayaDön.Text = "Ana Sayfaya Dön";
            this.btnAnasayfayaDön.UseVisualStyleBackColor = true;
            this.btnAnasayfayaDön.Click += new System.EventHandler(this.btnAnasayfayaDön_Click);
            // 
            // cboUrunler
            // 
            this.cboUrunler.FormattingEnabled = true;
            this.cboUrunler.Location = new System.Drawing.Point(12, 43);
            this.cboUrunler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboUrunler.Name = "cboUrunler";
            this.cboUrunler.Size = new System.Drawing.Size(160, 27);
            this.cboUrunler.TabIndex = 9;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(178, 45);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(175, 26);
            this.nudAdet.TabIndex = 10;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblKalanTutar
            // 
            this.lblKalanTutar.AutoSize = true;
            this.lblKalanTutar.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKalanTutar.Location = new System.Drawing.Point(548, 230);
            this.lblKalanTutar.Name = "lblKalanTutar";
            this.lblKalanTutar.Size = new System.Drawing.Size(101, 35);
            this.lblKalanTutar.TabIndex = 12;
            this.lblKalanTutar.Text = "00,00₺";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ödenen Tutar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kalan Tutar:";
            // 
            // txtOdenenTutar
            // 
            this.txtOdenenTutar.BackColor = System.Drawing.Color.Olive;
            this.txtOdenenTutar.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdenenTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtOdenenTutar.Location = new System.Drawing.Point(554, 145);
            this.txtOdenenTutar.Name = "txtOdenenTutar";
            this.txtOdenenTutar.Size = new System.Drawing.Size(85, 42);
            this.txtOdenenTutar.TabIndex = 15;
            this.txtOdenenTutar.Text = "0";
            // 
            // btnHesabiBeklet
            // 
            this.btnHesabiBeklet.Location = new System.Drawing.Point(395, 288);
            this.btnHesabiBeklet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHesabiBeklet.Name = "btnHesabiBeklet";
            this.btnHesabiBeklet.Size = new System.Drawing.Size(228, 52);
            this.btnHesabiBeklet.TabIndex = 16;
            this.btnHesabiBeklet.Text = "Bir Miktar Ödeme Alındı Hesabı Beklet";
            this.btnHesabiBeklet.UseVisualStyleBackColor = true;
            this.btnHesabiBeklet.Click += new System.EventHandler(this.btnHesabiBeklet_Click);
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(651, 540);
            this.Controls.Add(this.btnHesabiBeklet);
            this.Controls.Add(this.txtOdenenTutar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblKalanTutar);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.cboUrunler);
            this.Controls.Add(this.btnAnasayfayaDön);
            this.Controls.Add(this.btnMasayiIptalEt);
            this.Controls.Add(this.btnHesabiKapat);
            this.Controls.Add(this.btnSiparisDetayEkle);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSiparisDetaylar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisDetaylar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSiparisDetayEkle;
        private System.Windows.Forms.Button btnHesabiKapat;
        private System.Windows.Forms.Button btnMasayiIptalEt;
        private System.Windows.Forms.Button btnAnasayfayaDön;
        private System.Windows.Forms.ComboBox cboUrunler;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Label lblKalanTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOdenenTutar;
        private System.Windows.Forms.Button btnHesabiBeklet;
    }
}