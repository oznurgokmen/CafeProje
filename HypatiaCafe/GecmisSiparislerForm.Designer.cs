namespace HypatiaCafe
{
    partial class GecmisSiparislerForm
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
            this.dgvGecmisSiparisler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGecmisSiparisler
            // 
            this.dgvGecmisSiparisler.AllowUserToAddRows = false;
            this.dgvGecmisSiparisler.AllowUserToDeleteRows = false;
            this.dgvGecmisSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecmisSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGecmisSiparisler.Location = new System.Drawing.Point(0, 0);
            this.dgvGecmisSiparisler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvGecmisSiparisler.Name = "dgvGecmisSiparisler";
            this.dgvGecmisSiparisler.ReadOnly = true;
            this.dgvGecmisSiparisler.RowTemplate.Height = 24;
            this.dgvGecmisSiparisler.Size = new System.Drawing.Size(822, 518);
            this.dgvGecmisSiparisler.TabIndex = 0;
            // 
            // GecmisSiparislerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 518);
            this.Controls.Add(this.dgvGecmisSiparisler);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GecmisSiparislerForm";
            this.Text = "Geçmiş Siparişler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisSiparisler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGecmisSiparisler;
    }
}