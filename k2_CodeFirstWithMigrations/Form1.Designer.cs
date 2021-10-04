
namespace k2_CodeFirstWithMigrations
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
            this.btnFakulteEkle = new System.Windows.Forms.Button();
            this.btnBolmEkle = new System.Windows.Forms.Button();
            this.btnEgitmenEkle = new System.Windows.Forms.Button();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFakulteEkle
            // 
            this.btnFakulteEkle.Location = new System.Drawing.Point(56, 128);
            this.btnFakulteEkle.Name = "btnFakulteEkle";
            this.btnFakulteEkle.Size = new System.Drawing.Size(168, 23);
            this.btnFakulteEkle.TabIndex = 0;
            this.btnFakulteEkle.Text = "Fakülte Ekle";
            this.btnFakulteEkle.UseVisualStyleBackColor = true;
            this.btnFakulteEkle.Click += new System.EventHandler(this.btnFakulteEkle_Click);
            // 
            // btnBolmEkle
            // 
            this.btnBolmEkle.Location = new System.Drawing.Point(56, 157);
            this.btnBolmEkle.Name = "btnBolmEkle";
            this.btnBolmEkle.Size = new System.Drawing.Size(168, 23);
            this.btnBolmEkle.TabIndex = 1;
            this.btnBolmEkle.Text = "Bölüm ekle";
            this.btnBolmEkle.UseVisualStyleBackColor = true;
            this.btnBolmEkle.Click += new System.EventHandler(this.btnBolmEkle_Click);
            // 
            // btnEgitmenEkle
            // 
            this.btnEgitmenEkle.Location = new System.Drawing.Point(56, 186);
            this.btnEgitmenEkle.Name = "btnEgitmenEkle";
            this.btnEgitmenEkle.Size = new System.Drawing.Size(168, 23);
            this.btnEgitmenEkle.TabIndex = 2;
            this.btnEgitmenEkle.Text = "Eğitmen Ekle";
            this.btnEgitmenEkle.UseVisualStyleBackColor = true;
            this.btnEgitmenEkle.Click += new System.EventHandler(this.btnEgitmenEkle_Click);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(56, 226);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(168, 23);
            this.btnOgrenciEkle.TabIndex = 3;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.btnEgitmenEkle);
            this.Controls.Add(this.btnBolmEkle);
            this.Controls.Add(this.btnFakulteEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFakulteEkle;
        private System.Windows.Forms.Button btnBolmEkle;
        private System.Windows.Forms.Button btnEgitmenEkle;
        private System.Windows.Forms.Button btnOgrenciEkle;
    }
}

