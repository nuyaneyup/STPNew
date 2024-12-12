namespace STP582App.View
{
    partial class frmTedarikciIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTedarikciIslemleri));
            groupBox1 = new GroupBox();
            grdKategoriler = new DataGridView();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            label1 = new Label();
            txtFirmaAdi = new TextBox();
            btnYeni = new Button();
            label2 = new Label();
            txtYetkiliAdi = new TextBox();
            txtAdres = new RichTextBox();
            label3 = new Label();
            mskTelefon = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            txtMail = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdKategoriler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(mskTelefon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtYetkiliAdi);
            groupBox1.Controls.Add(grdKategoriler);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFirmaAdi);
            groupBox1.Controls.Add(btnYeni);
            groupBox1.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(870, 404);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "BILGI ISLEMLERI";
            // 
            // grdKategoriler
            // 
            grdKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdKategoriler.Location = new Point(0, 246);
            grdKategoriler.Name = "grdKategoriler";
            grdKategoriler.RowTemplate.Height = 25;
            grdKategoriler.Size = new Size(871, 158);
            grdKategoriler.TabIndex = 6;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Image = (Image)resources.GetObject("btnGuncelle.Image");
            btnGuncelle.ImageAlign = ContentAlignment.MiddleRight;
            btnGuncelle.Location = new Point(316, 183);
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
            btnSil.Location = new Point(242, 183);
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
            btnEkle.Location = new Point(155, 183);
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
            label1.Location = new Point(17, 45);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 2;
            label1.Text = "Firma Adı :";
            // 
            // txtFirmaAdi
            // 
            txtFirmaAdi.Location = new Point(120, 45);
            txtFirmaAdi.Name = "txtFirmaAdi";
            txtFirmaAdi.Size = new Size(157, 24);
            txtFirmaAdi.TabIndex = 1;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 51);
            label2.Name = "label2";
            label2.Size = new Size(149, 19);
            label2.TabIndex = 8;
            label2.Text = "Yetkili Ad Soyad :";
            // 
            // txtYetkiliAdi
            // 
            txtYetkiliAdi.Location = new Point(455, 48);
            txtYetkiliAdi.Name = "txtYetkiliAdi";
            txtYetkiliAdi.Size = new Size(157, 24);
            txtYetkiliAdi.TabIndex = 7;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(706, 48);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(157, 80);
            txtAdres.TabIndex = 9;
            txtAdres.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(633, 53);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 10;
            label3.Text = "Adres :";
            // 
            // mskTelefon
            // 
            mskTelefon.Location = new Point(119, 101);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(158, 24);
            mskTelefon.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 104);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 12;
            label4.Text = "Telefon :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 107);
            label5.Name = "label5";
            label5.Size = new Size(51, 19);
            label5.TabIndex = 14;
            label5.Text = "Mail :";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(455, 104);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(157, 24);
            txtMail.TabIndex = 13;
            // 
            // frmTedarikciIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 430);
            Controls.Add(groupBox1);
            Name = "frmTedarikciIslemleri";
            Text = "Tedarilçi İşlemleri";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdKategoriler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtYetkiliAdi;
        private DataGridView grdKategoriler;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Label label1;
        private TextBox txtFirmaAdi;
        private Button btnYeni;
        private RichTextBox txtAdres;
        private MaskedTextBox mskTelefon;
        private Label label3;
        private Label label5;
        private TextBox txtMail;
        private Label label4;
    }
}