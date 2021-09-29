
namespace k1_CodeFirst
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(82, 44);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(174, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(82, 154);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(174, 23);
            this.btnKategoriEkle.TabIndex = 1;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(82, 264);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(174, 23);
            this.btnKategoriGuncelle.TabIndex = 2;
            this.btnKategoriGuncelle.Text = "Kategori Gücncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Location = new System.Drawing.Point(82, 374);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(174, 23);
            this.btnKategoriSil.TabIndex = 3;
            this.btnKategoriSil.Text = "Kategori Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.btnKategoriGuncelle);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnKategoriSil;
    }
}

