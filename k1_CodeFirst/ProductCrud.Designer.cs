
namespace k1_CodeFirst
{
    partial class ProductCrud
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
            this.btnUrunListele = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunSilme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunListele
            // 
            this.btnUrunListele.Location = new System.Drawing.Point(122, 25);
            this.btnUrunListele.Name = "btnUrunListele";
            this.btnUrunListele.Size = new System.Drawing.Size(161, 23);
            this.btnUrunListele.TabIndex = 0;
            this.btnUrunListele.Text = "Ürün Listele";
            this.btnUrunListele.UseVisualStyleBackColor = true;
            this.btnUrunListele.Click += new System.EventHandler(this.btnUrunListele_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(122, 130);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(161, 23);
            this.btnUrunGuncelle.TabIndex = 1;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(122, 235);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(161, 23);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunSilme
            // 
            this.btnUrunSilme.Location = new System.Drawing.Point(122, 340);
            this.btnUrunSilme.Name = "btnUrunSilme";
            this.btnUrunSilme.Size = new System.Drawing.Size(161, 23);
            this.btnUrunSilme.TabIndex = 3;
            this.btnUrunSilme.Text = "Ürün Silme";
            this.btnUrunSilme.UseVisualStyleBackColor = true;
            this.btnUrunSilme.Click += new System.EventHandler(this.btnUrunSilme_Click);
            // 
            // ProductCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUrunSilme);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnUrunListele);
            this.Name = "ProductCrud";
            this.Text = "ProductCrud";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunListele;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunSilme;
    }
}