namespace Odev2
{
    partial class Form1
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
            this.btnDKListesi = new System.Windows.Forms.Button();
            this.btnBKOKListesi = new System.Windows.Forms.Button();
            this.btnKBOKListesi = new System.Windows.Forms.Button();
            this.btnKBAzBekleyen = new System.Windows.Forms.Button();
            this.btnBKAzBekleyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDKListesi
            // 
            this.btnDKListesi.Location = new System.Drawing.Point(42, 28);
            this.btnDKListesi.Name = "btnDKListesi";
            this.btnDKListesi.Size = new System.Drawing.Size(278, 52);
            this.btnDKListesi.TabIndex = 0;
            this.btnDKListesi.Text = "Dairesel Kuyruk için Müşteri Listesi ve Ortalama İşlem Tamamlanma Süresi";
            this.btnDKListesi.UseVisualStyleBackColor = true;
            this.btnDKListesi.Click += new System.EventHandler(this.btnDKListesi_Click);
            // 
            // btnBKOKListesi
            // 
            this.btnBKOKListesi.Location = new System.Drawing.Point(42, 209);
            this.btnBKOKListesi.Name = "btnBKOKListesi";
            this.btnBKOKListesi.Size = new System.Drawing.Size(278, 58);
            this.btnBKOKListesi.TabIndex = 2;
            this.btnBKOKListesi.Text = "Öncelikli Kuyruk(Büyükten Küçükğe) için Müşteri Listesi ve Ortalama İşlem Tamamla" +
    "nma Süresi";
            this.btnBKOKListesi.UseVisualStyleBackColor = true;
            this.btnBKOKListesi.Click += new System.EventHandler(this.btnBKOKListesi_Click);
            // 
            // btnKBOKListesi
            // 
            this.btnKBOKListesi.Location = new System.Drawing.Point(42, 86);
            this.btnKBOKListesi.Name = "btnKBOKListesi";
            this.btnKBOKListesi.Size = new System.Drawing.Size(278, 58);
            this.btnKBOKListesi.TabIndex = 3;
            this.btnKBOKListesi.Text = "Öncelikli Kuyruk (Küçükten Büyüğe) için Müşteri Listesi ve Ortalama İşlem Tamamla" +
    "nma Süresi";
            this.btnKBOKListesi.UseVisualStyleBackColor = true;
            this.btnKBOKListesi.Click += new System.EventHandler(this.btnKBOKListesi_Click);
            // 
            // btnKBAzBekleyen
            // 
            this.btnKBAzBekleyen.Location = new System.Drawing.Point(42, 150);
            this.btnKBAzBekleyen.Name = "btnKBAzBekleyen";
            this.btnKBAzBekleyen.Size = new System.Drawing.Size(278, 43);
            this.btnKBAzBekleyen.TabIndex = 6;
            this.btnKBAzBekleyen.Text = " Dairesele Göre Daha Az Bekleyenlerin Listesi(Küçükten Büyüğe)";
            this.btnKBAzBekleyen.UseVisualStyleBackColor = true;
            this.btnKBAzBekleyen.Click += new System.EventHandler(this.btnKBAzBekleyen_Click);
            // 
            // btnBKAzBekleyen
            // 
            this.btnBKAzBekleyen.Location = new System.Drawing.Point(42, 284);
            this.btnBKAzBekleyen.Name = "btnBKAzBekleyen";
            this.btnBKAzBekleyen.Size = new System.Drawing.Size(278, 39);
            this.btnBKAzBekleyen.TabIndex = 7;
            this.btnBKAzBekleyen.Text = "Dairesele Göre Daha Az Bekleyenlerin Listesi(Büyükten Küçüğe)";
            this.btnBKAzBekleyen.UseVisualStyleBackColor = true;
            this.btnBKAzBekleyen.Click += new System.EventHandler(this.btnBKAzBekleyen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 376);
            this.Controls.Add(this.btnBKAzBekleyen);
            this.Controls.Add(this.btnKBAzBekleyen);
            this.Controls.Add(this.btnKBOKListesi);
            this.Controls.Add(this.btnBKOKListesi);
            this.Controls.Add(this.btnDKListesi);
            this.Name = "Form1";
            this.Text = "TURGUTLU BANKASI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDKListesi;
        private System.Windows.Forms.Button btnBKOKListesi;
        private System.Windows.Forms.Button btnKBOKListesi;
        private System.Windows.Forms.Button btnKBAzBekleyen;
        private System.Windows.Forms.Button btnBKAzBekleyen;
    }
}

