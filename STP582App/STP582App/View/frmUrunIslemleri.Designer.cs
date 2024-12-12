namespace STP582App.View
{
    partial class frmUrunIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunIslemleri));
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtAciklama = new RichTextBox();
            label2 = new Label();
            grdKategoriler = new DataGridView();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            label1 = new Label();
            txtUrunAdi = new TextBox();
            btnYeni = new Button();
            cmbTedarikci = new ComboBox();
            cmbKategori = new ComboBox();
            btnKategori = new Button();
            nmrStok = new NumericUpDown();
            label6 = new Label();
            txtFiyat = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdKategoriler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrStok).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtFiyat);
            groupBox1.Controls.Add(nmrStok);
            groupBox1.Controls.Add(btnKategori);
            groupBox1.Controls.Add(cmbKategori);
            groupBox1.Controls.Add(cmbTedarikci);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(grdKategoriler);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUrunAdi);
            groupBox1.Controls.Add(btnYeni);
            groupBox1.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(1, 0);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(901, 349);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "BILGI ISLEMLERI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(608, 49);
            label5.Name = "label5";
            label5.Size = new Size(93, 19);
            label5.TabIndex = 14;
            label5.Text = "Tedarikçi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 106);
            label4.Name = "label4";
            label4.Size = new Size(104, 19);
            label4.TabIndex = 12;
            label4.Text = "Stok Adedi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 103);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 10;
            label3.Text = "Kategori :";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(96, 100);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(157, 99);
            txtAciklama.TabIndex = 9;
            txtAciklama.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 48);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 8;
            label2.Text = "Kategori :";
            // 
            // grdKategoriler
            // 
            grdKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdKategoriler.Location = new Point(0, 246);
            grdKategoriler.Name = "grdKategoriler";
            grdKategoriler.RowTemplate.Height = 25;
            grdKategoriler.Size = new Size(903, 147);
            grdKategoriler.TabIndex = 6;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Image = (Image)resources.GetObject("btnGuncelle.Image");
            btnGuncelle.ImageAlign = ContentAlignment.MiddleRight;
            btnGuncelle.Location = new Point(781, 175);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(115, 36);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.TextAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Image = (Image)resources.GetObject("btnSil.Image");
            btnSil.ImageAlign = ContentAlignment.MiddleRight;
            btnSil.Location = new Point(707, 175);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(68, 36);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleLeft;
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Image = (Image)resources.GetObject("btnEkle.Image");
            btnEkle.ImageAlign = ContentAlignment.MiddleRight;
            btnEkle.Location = new Point(620, 175);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(81, 36);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.TextAlign = ContentAlignment.MiddleLeft;
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 43);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 2;
            label1.Text = "Ürün Adı :";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(96, 43);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(157, 24);
            txtUrunAdi.TabIndex = 1;
            // 
            // btnYeni
            // 
            btnYeni.Font = new Font("Bauhaus 93", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnYeni.Image = (Image)resources.GetObject("btnYeni.Image");
            btnYeni.ImageAlign = ContentAlignment.MiddleRight;
            btnYeni.Location = new Point(259, 162);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(99, 37);
            btnYeni.TabIndex = 0;
            btnYeni.Text = "Yeni Kayıt";
            btnYeni.TextAlign = ContentAlignment.MiddleLeft;
            btnYeni.UseVisualStyleBackColor = true;
            // 
            // cmbTedarikci
            // 
            cmbTedarikci.FormattingEnabled = true;
            cmbTedarikci.Location = new Point(699, 46);
            cmbTedarikci.Name = "cmbTedarikci";
            cmbTedarikci.Size = new Size(157, 27);
            cmbTedarikci.TabIndex = 15;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(389, 46);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(157, 27);
            cmbKategori.TabIndex = 16;
            // 
            // btnKategori
            // 
            btnKategori.Location = new Point(552, 48);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(35, 25);
            btnKategori.TabIndex = 17;
            btnKategori.Text = "...";
            btnKategori.TextAlign = ContentAlignment.TopCenter;
            btnKategori.UseVisualStyleBackColor = true;
            // 
            // nmrStok
            // 
            nmrStok.Location = new Point(389, 104);
            nmrStok.Name = "nmrStok";
            nmrStok.Size = new Size(141, 24);
            nmrStok.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(635, 111);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 20;
            label6.Text = "Fiyat :";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(699, 108);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(157, 24);
            txtFiyat.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(862, 111);
            label7.Name = "label7";
            label7.Size = new Size(19, 23);
            label7.TabIndex = 21;
            label7.Text = "₺";
            // 
            // frmUrunIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 350);
            Controls.Add(groupBox1);
            Name = "frmUrunIslemleri";
            Text = "frmUrunIslemleri";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdKategoriler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrStok).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox txtAciklama;
        private Label label2;
        private DataGridView grdKategoriler;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Label label1;
        private TextBox txtUrunAdi;
        private Button btnYeni;
        private Button btnKategori;
        private ComboBox cmbKategori;
        private ComboBox cmbTedarikci;
        private Label label7;
        private Label label6;
        private TextBox txtFiyat;
        private NumericUpDown nmrStok;
    }
}