namespace STP582App.View
{
    partial class frmKategoriIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategoriIslemleri));
            groupBox1 = new GroupBox();
            grdKategoriler = new DataGridView();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            label1 = new Label();
            txtKategoriAdi = new TextBox();
            btnYeni = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdKategoriler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grdKategoriler);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtKategoriAdi);
            groupBox1.Controls.Add(btnYeni);
            groupBox1.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(470, 245);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "BILGI ISLEMLERI";
            // 
            // grdKategoriler
            // 
            grdKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdKategoriler.Location = new Point(0, 160);
            grdKategoriler.Name = "grdKategoriler";
            grdKategoriler.RowTemplate.Height = 25;
            grdKategoriler.Size = new Size(470, 78);
            grdKategoriler.TabIndex = 6;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Image = (Image)resources.GetObject("btnGuncelle.Image");
            btnGuncelle.ImageAlign = ContentAlignment.MiddleRight;
            btnGuncelle.Location = new Point(316, 101);
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
            btnSil.Location = new Point(242, 101);
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
            btnEkle.Location = new Point(155, 101);
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
            label1.Location = new Point(16, 69);
            label1.Name = "label1";
            label1.Size = new Size(120, 19);
            label1.TabIndex = 2;
            label1.Text = "Kategori Adı :";
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(153, 66);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(157, 24);
            txtKategoriAdi.TabIndex = 1;
            // 
            // btnYeni
            // 
            btnYeni.Font = new Font("Bauhaus 93", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnYeni.Image = (Image)resources.GetObject("btnYeni.Image");
            btnYeni.ImageAlign = ContentAlignment.MiddleRight;
            btnYeni.Location = new Point(364, 14);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(99, 37);
            btnYeni.TabIndex = 0;
            btnYeni.Text = "Yeni Kayıt";
            btnYeni.TextAlign = ContentAlignment.MiddleLeft;
            btnYeni.UseVisualStyleBackColor = true;
            // 
            // frmKategoriIslemleri
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(479, 250);
            Controls.Add(groupBox1);
            Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmKategoriIslemleri";
            Text = "frmKategoriIslemleri";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdKategoriler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtKategoriAdi;
        private DataGridView grdKategoriler;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Button btnYeni;
    }
}