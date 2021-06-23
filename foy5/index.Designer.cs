
namespace foy5
{
    partial class index
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
            this.buton1 = new System.Windows.Forms.Button();
            this.buton2 = new System.Windows.Forms.Button();
            this.buton3 = new System.Windows.Forms.Button();
            this.buton4 = new System.Windows.Forms.Button();
            this.buton5 = new System.Windows.Forms.Button();
            this.buton6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buton1
            // 
            this.buton1.Location = new System.Drawing.Point(12, 32);
            this.buton1.Name = "buton1";
            this.buton1.Size = new System.Drawing.Size(283, 23);
            this.buton1.TabIndex = 0;
            this.buton1.Text = "Ekran 1";
            this.buton1.UseVisualStyleBackColor = true;
            this.buton1.Click += new System.EventHandler(this.buton1_Click);
            // 
            // buton2
            // 
            this.buton2.Location = new System.Drawing.Point(12, 86);
            this.buton2.Name = "buton2";
            this.buton2.Size = new System.Drawing.Size(283, 23);
            this.buton2.TabIndex = 1;
            this.buton2.Text = "Ekran 2";
            this.buton2.UseVisualStyleBackColor = true;
            this.buton2.Click += new System.EventHandler(this.buton2_Click);
            // 
            // buton3
            // 
            this.buton3.Location = new System.Drawing.Point(12, 140);
            this.buton3.Name = "buton3";
            this.buton3.Size = new System.Drawing.Size(283, 23);
            this.buton3.TabIndex = 2;
            this.buton3.Text = "Ekran 3";
            this.buton3.UseVisualStyleBackColor = true;
            this.buton3.Click += new System.EventHandler(this.buton3_Click);
            // 
            // buton4
            // 
            this.buton4.Location = new System.Drawing.Point(17, 197);
            this.buton4.Name = "buton4";
            this.buton4.Size = new System.Drawing.Size(283, 23);
            this.buton4.TabIndex = 3;
            this.buton4.Text = "Ekran 4";
            this.buton4.UseVisualStyleBackColor = true;
            this.buton4.Click += new System.EventHandler(this.buton4_Click);
            // 
            // buton5
            // 
            this.buton5.Location = new System.Drawing.Point(17, 255);
            this.buton5.Name = "buton5";
            this.buton5.Size = new System.Drawing.Size(283, 23);
            this.buton5.TabIndex = 4;
            this.buton5.Text = "Ekran 5";
            this.buton5.UseVisualStyleBackColor = true;
            this.buton5.Click += new System.EventHandler(this.buton5_Click);
            // 
            // buton6
            // 
            this.buton6.Location = new System.Drawing.Point(17, 311);
            this.buton6.Name = "buton6";
            this.buton6.Size = new System.Drawing.Size(283, 23);
            this.buton6.TabIndex = 5;
            this.buton6.Text = "Ekran 6";
            this.buton6.UseVisualStyleBackColor = true;
            this.buton6.Click += new System.EventHandler(this.buton6_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 417);
            this.Controls.Add(this.buton6);
            this.Controls.Add(this.buton5);
            this.Controls.Add(this.buton4);
            this.Controls.Add(this.buton3);
            this.Controls.Add(this.buton2);
            this.Controls.Add(this.buton1);
            this.Name = "index";
            this.Text = "index";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buton1;
        private System.Windows.Forms.Button buton2;
        private System.Windows.Forms.Button buton3;
        private System.Windows.Forms.Button buton4;
        private System.Windows.Forms.Button buton5;
        private System.Windows.Forms.Button buton6;
    }
}

