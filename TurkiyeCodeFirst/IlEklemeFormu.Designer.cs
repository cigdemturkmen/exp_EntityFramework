
namespace TurkiyeCodeFirst
{
    partial class IlEklemeFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSehirAdi = new System.Windows.Forms.TextBox();
            this.txtPlakaKodu = new System.Windows.Forms.TextBox();
            this.txtAlanKodu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plaka Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alan Kodu";
            // 
            // txtSehirAdi
            // 
            this.txtSehirAdi.Location = new System.Drawing.Point(104, 90);
            this.txtSehirAdi.Name = "txtSehirAdi";
            this.txtSehirAdi.Size = new System.Drawing.Size(100, 22);
            this.txtSehirAdi.TabIndex = 3;
            // 
            // txtPlakaKodu
            // 
            this.txtPlakaKodu.Location = new System.Drawing.Point(104, 117);
            this.txtPlakaKodu.Name = "txtPlakaKodu";
            this.txtPlakaKodu.Size = new System.Drawing.Size(100, 22);
            this.txtPlakaKodu.TabIndex = 4;
            // 
            // txtAlanKodu
            // 
            this.txtAlanKodu.Location = new System.Drawing.Point(104, 144);
            this.txtAlanKodu.Name = "txtAlanKodu";
            this.txtAlanKodu.Size = new System.Drawing.Size(100, 22);
            this.txtAlanKodu.TabIndex = 5;
            // 
            // IlEklemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAlanKodu);
            this.Controls.Add(this.txtPlakaKodu);
            this.Controls.Add(this.txtSehirAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IlEklemeFormu";
            this.Text = "IlEklemeFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSehirAdi;
        private System.Windows.Forms.TextBox txtPlakaKodu;
        private System.Windows.Forms.TextBox txtAlanKodu;
    }
}