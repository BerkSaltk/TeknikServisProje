namespace TeknikServis
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnteknikservisgiris = new System.Windows.Forms.Button();
            this.btnyoneticigiris = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbltarih = new System.Windows.Forms.Label();
            this.btnpersonel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "TEKNOLOJİ";
            // 
            // btnteknikservisgiris
            // 
            this.btnteknikservisgiris.Location = new System.Drawing.Point(218, 222);
            this.btnteknikservisgiris.Name = "btnteknikservisgiris";
            this.btnteknikservisgiris.Size = new System.Drawing.Size(103, 34);
            this.btnteknikservisgiris.TabIndex = 3;
            this.btnteknikservisgiris.Text = "Teknik Servis";
            this.btnteknikservisgiris.UseVisualStyleBackColor = true;
            this.btnteknikservisgiris.Click += new System.EventHandler(this.btnteknikservisgiris_Click);
            // 
            // btnyoneticigiris
            // 
            this.btnyoneticigiris.Location = new System.Drawing.Point(218, 279);
            this.btnyoneticigiris.Name = "btnyoneticigiris";
            this.btnyoneticigiris.Size = new System.Drawing.Size(103, 34);
            this.btnyoneticigiris.TabIndex = 4;
            this.btnyoneticigiris.Text = "Yönetici ";
            this.btnyoneticigiris.UseVisualStyleBackColor = true;
            this.btnyoneticigiris.Click += new System.EventHandler(this.btnyoneticigiris_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(181, 222);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(181, 279);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.BackColor = System.Drawing.Color.Transparent;
            this.lbltarih.Location = new System.Drawing.Point(286, 12);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(35, 13);
            this.lbltarih.TabIndex = 8;
            this.lbltarih.Text = "label2";
            // 
            // btnpersonel
            // 
            this.btnpersonel.Location = new System.Drawing.Point(218, 164);
            this.btnpersonel.Name = "btnpersonel";
            this.btnpersonel.Size = new System.Drawing.Size(103, 34);
            this.btnpersonel.TabIndex = 9;
            this.btnpersonel.Text = "Müşteri Temsilcisi";
            this.btnpersonel.UseVisualStyleBackColor = true;
            this.btnpersonel.Click += new System.EventHandler(this.btnpersonel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(181, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 55);
            this.label2.TabIndex = 11;
            this.label2.Text = "BERKO";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(397, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnpersonel);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnyoneticigiris);
            this.Controls.Add(this.btnteknikservisgiris);
            this.Controls.Add(this.label1);
            this.Name = "AnaForm";
            this.Text = "BERKO TEKNOLOJİ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnteknikservisgiris;
        private System.Windows.Forms.Button btnyoneticigiris;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Button btnpersonel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

