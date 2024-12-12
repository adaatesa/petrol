namespace PetrolOtomasyon
{
    partial class Form1
    {
        /// <summary>
        /// Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        /// <param name="disposing">yönetilen kaynaklar mı temizlensin, yoksa temizlenmesin mi?</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer oluşturulan kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - 
        /// Bu metodun içeriğini kod düzenleyiciyle değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(65, 47);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(150, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Müdür";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(593, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "Fiş Gönüntüleme";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(593, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 57);
            this.button5.TabIndex = 4;
            this.button5.Text = "Kasa Yönetimi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(325, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 57);
            this.button6.TabIndex = 5;
            this.button6.Text = "Pompacı Satış Ekranı";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 57);
            this.button2.TabIndex = 6;
            this.button2.Text = "Şube Yöentimi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(325, 323);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 57);
            this.button7.TabIndex = 8;
            this.button7.Text = "Şube Gün Sonu Raporu";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(65, 323);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 57);
            this.button8.TabIndex = 9;
            this.button8.Text = "Maaş Hesaplama";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(593, 190);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 57);
            this.button9.TabIndex = 10;
            this.button9.Text = "Yakıt Sorgulama";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(325, 190);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(150, 57);
            this.button10.TabIndex = 11;
            this.button10.Text = "Depo Yönetimi";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}
