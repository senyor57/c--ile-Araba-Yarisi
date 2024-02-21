namespace Araba_Yarısı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.carpma = new System.Windows.Forms.PictureBox();
            this.BizimAraba = new System.Windows.Forms.PictureBox();
            this.Araba2 = new System.Windows.Forms.PictureBox();
            this.Araba1 = new System.Windows.Forms.PictureBox();
            this.Yol = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPuan = new System.Windows.Forms.Label();
            this.buttonOyunuBaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BizimAraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.carpma);
            this.panel1.Controls.Add(this.BizimAraba);
            this.panel1.Controls.Add(this.Araba2);
            this.panel1.Controls.Add(this.Araba1);
            this.panel1.Controls.Add(this.Yol);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // carpma
            // 
            this.carpma.Image = global::Araba_Yarısı.Properties.Resources.explosion;
            this.carpma.Location = new System.Drawing.Point(277, 300);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(100, 50);
            this.carpma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carpma.TabIndex = 2;
            this.carpma.TabStop = false;
            // 
            // BizimAraba
            // 
            this.BizimAraba.Image = global::Araba_Yarısı.Properties.Resources.araba5;
            this.BizimAraba.Location = new System.Drawing.Point(221, 356);
            this.BizimAraba.Name = "BizimAraba";
            this.BizimAraba.Size = new System.Drawing.Size(69, 134);
            this.BizimAraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BizimAraba.TabIndex = 1;
            this.BizimAraba.TabStop = false;
            // 
            // Araba2
            // 
            this.Araba2.Image = global::Araba_Yarısı.Properties.Resources.araba8;
            this.Araba2.Location = new System.Drawing.Point(345, 60);
            this.Araba2.Name = "Araba2";
            this.Araba2.Size = new System.Drawing.Size(69, 134);
            this.Araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Araba2.TabIndex = 1;
            this.Araba2.TabStop = false;
            // 
            // Araba1
            // 
            this.Araba1.Image = global::Araba_Yarısı.Properties.Resources.araba4;
            this.Araba1.Location = new System.Drawing.Point(80, 60);
            this.Araba1.Name = "Araba1";
            this.Araba1.Size = new System.Drawing.Size(69, 134);
            this.Araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Araba1.TabIndex = 1;
            this.Araba1.TabStop = false;
            // 
            // Yol
            // 
            this.Yol.Image = global::Araba_Yarısı.Properties.Resources.yol;
            this.Yol.Location = new System.Drawing.Point(3, -252);
            this.Yol.Name = "Yol";
            this.Yol.Size = new System.Drawing.Size(513, 775);
            this.Yol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Yol.TabIndex = 0;
            this.Yol.TabStop = false;
            this.Yol.Click += new System.EventHandler(this.Yol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(183, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puan :";
            // 
            // labelPuan
            // 
            this.labelPuan.AutoSize = true;
            this.labelPuan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPuan.Location = new System.Drawing.Point(272, 542);
            this.labelPuan.Name = "labelPuan";
            this.labelPuan.Size = new System.Drawing.Size(25, 27);
            this.labelPuan.TabIndex = 1;
            this.labelPuan.Text = "0";
            // 
            // buttonOyunuBaslat
            // 
            this.buttonOyunuBaslat.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOyunuBaslat.Location = new System.Drawing.Point(-2, 592);
            this.buttonOyunuBaslat.Name = "buttonOyunuBaslat";
            this.buttonOyunuBaslat.Size = new System.Drawing.Size(530, 47);
            this.buttonOyunuBaslat.TabIndex = 2;
            this.buttonOyunuBaslat.Text = "Oyunu Başlat";
            this.buttonOyunuBaslat.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 648);
            this.Controls.Add(this.buttonOyunuBaslat);
            this.Controls.Add(this.labelPuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Araba Yarisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BizimAraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Yol;
        private System.Windows.Forms.PictureBox BizimAraba;
        private System.Windows.Forms.PictureBox Araba2;
        private System.Windows.Forms.PictureBox Araba1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPuan;
        private System.Windows.Forms.Button buttonOyunuBaslat;
        private System.Windows.Forms.PictureBox carpma;
        private System.Windows.Forms.Timer timer1;
    }
}

