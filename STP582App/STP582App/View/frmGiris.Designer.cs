namespace STP582App.View
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            label7 = new Label();
            txtSifre = new TextBox();
            label6 = new Label();
            txtKullanici = new TextBox();
            btnGiris = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(257, 117);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 19);
            label7.TabIndex = 22;
            label7.Text = "Sifre :";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(336, 111);
            txtSifre.Margin = new Padding(4, 4, 4, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(223, 26);
            txtSifre.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 54);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(127, 19);
            label6.TabIndex = 20;
            label6.Text = "kullanici Adi:";
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(336, 50);
            txtKullanici.Margin = new Padding(4, 4, 4, 4);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(223, 26);
            txtKullanici.TabIndex = 19;
            // 
            // btnGiris
            // 
            btnGiris.Image = (Image)resources.GetObject("btnGiris.Image");
            btnGiris.ImageAlign = ContentAlignment.MiddleRight;
            btnGiris.Location = new Point(374, 163);
            btnGiris.Margin = new Padding(4, 4, 4, 4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(116, 29);
            btnGiris.TabIndex = 23;
            btnGiris.Text = "Giris Yap";
            btnGiris.TextAlign = ContentAlignment.MiddleLeft;
            btnGiris.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 32);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 241);
            Controls.Add(pictureBox1);
            Controls.Add(btnGiris);
            Controls.Add(label7);
            Controls.Add(txtSifre);
            Controls.Add(label6);
            Controls.Add(txtKullanici);
            Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmGiris";
            Text = "frmGiris";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtSifre;
        private Label label6;
        private TextBox txtKullanici;
        private Button btnGiris;
        private PictureBox pictureBox1;
    }
}