namespace STP582App.View
{
    partial class frmPersonelIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelIslemleri));
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtMail = new TextBox();
            label4 = new Label();
            mskTelefon = new MaskedTextBox();
            label3 = new Label();
            txtAdres = new RichTextBox();
            label2 = new Label();
            txtAd = new TextBox();
            grdPersoneller = new DataGridView();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            label1 = new Label();
            txtSoyad = new TextBox();
            btnYeni = new Button();
            label6 = new Label();
            txtKullanici = new TextBox();
            label7 = new Label();
            txtSifre = new TextBox();
            cmbYetki = new ComboBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdPersoneller).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbYetki);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtKullanici);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(mskTelefon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(grdPersoneller);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(btnYeni);
            groupBox1.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(889, 420);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "BILGI ISLEMLERI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 92);
            label5.Name = "label5";
            label5.Size = new Size(51, 19);
            label5.TabIndex = 14;
            label5.Text = "Mail :";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(416, 87);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(157, 24);
            txtMail.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 90);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 12;
            label4.Text = "Telefon :";
            // 
            // mskTelefon
            // 
            mskTelefon.Location = new Point(129, 85);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(158, 24);
            mskTelefon.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(635, 55);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 10;
            label3.Text = "Adres :";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(706, 48);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(157, 63);
            txtAdres.TabIndex = 9;
            txtAdres.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 47);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 8;
            label2.Text = "Ad :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(129, 44);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(157, 24);
            txtAd.TabIndex = 7;
            // 
            // grdPersoneller
            // 
            grdPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPersoneller.Location = new Point(0, 246);
            grdPersoneller.Name = "grdPersoneller";
            grdPersoneller.RowTemplate.Height = 25;
            grdPersoneller.Size = new Size(871, 158);
            grdPersoneller.TabIndex = 6;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Image = (Image)resources.GetObject("btnGuncelle.Image");
            btnGuncelle.ImageAlign = ContentAlignment.MiddleRight;
            btnGuncelle.Location = new Point(751, 184);
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
            btnSil.Location = new Point(677, 184);
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
            btnEkle.Location = new Point(590, 184);
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
            label1.Location = new Point(345, 49);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 2;
            label1.Text = "Soyad :";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(416, 44);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(157, 24);
            txtSoyad.TabIndex = 1;
            // 
            // btnYeni
            // 
            btnYeni.Font = new Font("Bauhaus 93", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnYeni.Image = (Image)resources.GetObject("btnYeni.Image");
            btnYeni.ImageAlign = ContentAlignment.MiddleRight;
            btnYeni.Location = new Point(7, 183);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(99, 37);
            btnYeni.TabIndex = 0;
            btnYeni.Text = "Yeni Kayıt";
            btnYeni.TextAlign = ContentAlignment.MiddleLeft;
            btnYeni.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 131);
            label6.Name = "label6";
            label6.Size = new Size(120, 19);
            label6.TabIndex = 16;
            label6.Text = "Kullanıcı Adı :";
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(129, 128);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(157, 24);
            txtKullanici.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(361, 136);
            label7.Name = "label7";
            label7.Size = new Size(57, 19);
            label7.TabIndex = 18;
            label7.Text = "Şifre :";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(416, 131);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(157, 24);
            txtSifre.TabIndex = 17;
            // 
            // cmbYetki
            // 
            cmbYetki.FormattingEnabled = true;
            cmbYetki.Location = new Point(706, 128);
            cmbYetki.Name = "cmbYetki";
            cmbYetki.Size = new Size(157, 27);
            cmbYetki.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(635, 136);
            label8.Name = "label8";
            label8.Size = new Size(61, 19);
            label8.TabIndex = 20;
            label8.Text = "Yetki :";
            // 
            // frmPersonelIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 415);
            Controls.Add(groupBox1);
            Name = "frmPersonelIslemleri";
            Text = "frmPersonelIslemleri";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdPersoneller).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label8;
        private ComboBox cmbYetki;
        private Label label7;
        private TextBox txtSifre;
        private Label label6;
        private TextBox txtKullanici;
        private Label label5;
        private TextBox txtMail;
        private Label label4;
        private MaskedTextBox mskTelefon;
        private Label label3;
        private RichTextBox txtAdres;
        private Label label2;
        private TextBox txtAd;
        private DataGridView grdPersoneller;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Label label1;
        private TextBox txtSoyad;
        private Button btnYeni;
    }
}