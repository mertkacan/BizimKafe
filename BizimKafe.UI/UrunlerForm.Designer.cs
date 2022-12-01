namespace BizimKafe.UI
{
    partial class UrunlerForm
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
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.nudBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvUrunler.Location = new System.Drawing.Point(14, 72);
            this.dgvUrunler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 25;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(605, 406);
            this.dgvUrunler.TabIndex = 0;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(14, 35);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(161, 27);
            this.txtUrunAd.TabIndex = 1;
            // 
            // nudBirimFiyat
            // 
            this.nudBirimFiyat.Location = new System.Drawing.Point(181, 36);
            this.nudBirimFiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudBirimFiyat.Name = "nudBirimFiyat";
            this.nudBirimFiyat.Size = new System.Drawing.Size(105, 27);
            this.nudBirimFiyat.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(292, 33);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 31);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Birim Fiyatı (₺)";
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDüzenle.Location = new System.Drawing.Point(393, 518);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(94, 29);
            this.btnDüzenle.TabIndex = 6;
            this.btnDüzenle.Text = "DÜZENLE";
            this.btnDüzenle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Location = new System.Drawing.Point(493, 518);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 29);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(384, 33);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(94, 29);
            this.btnİptal.TabIndex = 8;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Visible = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UrunAd";
            this.Column1.HeaderText = "Ürün Adı";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BirimFiyat";
            this.Column2.HeaderText = "Birim Fiyatı";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 588);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDüzenle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudBirimFiyat);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.dgvUrunler);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UrunlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvUrunler;
        private TextBox txtUrunAd;
        private NumericUpDown nudBirimFiyat;
        private Button btnEkle;
        private Label label1;
        private Label label2;
        private Button btnDüzenle;
        private Button btnSil;
        private Button btnİptal;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}