namespace STP582App.View
{
    partial class frmSatisDetaylari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisDetaylari));
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            grdSatislar = new DataGridView();
            label1 = new Label();
            grdSatilanUrunler = new DataGridView();
            btnSatisIptal = new Button();
            label6 = new Label();
            label5 = new Label();
            txtSatisToplam = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSatislar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdSatilanUrunler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grdSatislar);
            groupBox1.Location = new Point(-1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 215);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Satış Listesi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSatisToplam);
            groupBox2.Controls.Add(btnSatisIptal);
            groupBox2.Controls.Add(grdSatilanUrunler);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(430, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 215);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Satış Detayları";
            // 
            // grdSatislar
            // 
            grdSatislar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSatislar.Location = new Point(7, 21);
            grdSatislar.Name = "grdSatislar";
            grdSatislar.RowTemplate.Height = 25;
            grdSatislar.Size = new Size(412, 188);
            grdSatislar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 33);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 0;
            label1.Text = "Satılan Ürünler";
            // 
            // grdSatilanUrunler
            // 
            grdSatilanUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSatilanUrunler.Location = new Point(6, 64);
            grdSatilanUrunler.Name = "grdSatilanUrunler";
            grdSatilanUrunler.RowTemplate.Height = 25;
            grdSatilanUrunler.Size = new Size(416, 73);
            grdSatilanUrunler.TabIndex = 1;
            // 
            // btnSatisIptal
            // 
            btnSatisIptal.Image = (Image)resources.GetObject("btnSatisIptal.Image");
            btnSatisIptal.ImageAlign = ContentAlignment.MiddleRight;
            btnSatisIptal.Location = new Point(9, 154);
            btnSatisIptal.Name = "btnSatisIptal";
            btnSatisIptal.Size = new Size(121, 38);
            btnSatisIptal.TabIndex = 2;
            btnSatisIptal.Text = "Satışı İptal Et";
            btnSatisIptal.TextAlign = ContentAlignment.MiddleLeft;
            btnSatisIptal.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 162);
            label6.Name = "label6";
            label6.Size = new Size(15, 17);
            label6.TabIndex = 26;
            label6.Text = "₺";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 165);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 25;
            label5.Text = "Toplam";
            // 
            // txtSatisToplam
            // 
            txtSatisToplam.Location = new Point(221, 162);
            txtSatisToplam.Name = "txtSatisToplam";
            txtSatisToplam.Size = new Size(95, 23);
            txtSatisToplam.TabIndex = 24;
            // 
            // frmSatisDetaylari
            // 
            AutoScaleDimensions = new SizeF(6F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 216);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmSatisDetaylari";
            Text = "frmSatisDetaylari";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdSatislar).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdSatilanUrunler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView grdSatislar;
        private GroupBox groupBox2;
        private Button btnSatisIptal;
        private DataGridView grdSatilanUrunler;
        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox txtSatisToplam;
    }
}