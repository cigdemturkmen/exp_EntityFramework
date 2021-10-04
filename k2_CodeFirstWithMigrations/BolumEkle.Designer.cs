
namespace k2_CodeFirstWithMigrations
{
    partial class BolumEkle
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
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.cmbFakulte = new System.Windows.Forms.ComboBox();
            this.lblFakulte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.Location = new System.Drawing.Point(115, 150);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(121, 23);
            this.btnBolumEkle.TabIndex = 0;
            this.btnBolumEkle.Text = "Kaydet";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölum Adı";
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Location = new System.Drawing.Point(115, 49);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(121, 20);
            this.txtBolumAdi.TabIndex = 2;
            // 
            // cmbFakulte
            // 
            this.cmbFakulte.FormattingEnabled = true;
            this.cmbFakulte.Location = new System.Drawing.Point(115, 102);
            this.cmbFakulte.Name = "cmbFakulte";
            this.cmbFakulte.Size = new System.Drawing.Size(121, 21);
            this.cmbFakulte.TabIndex = 3;
            // 
            // lblFakulte
            // 
            this.lblFakulte.AutoSize = true;
            this.lblFakulte.Location = new System.Drawing.Point(53, 105);
            this.lblFakulte.Name = "lblFakulte";
            this.lblFakulte.Size = new System.Drawing.Size(42, 13);
            this.lblFakulte.TabIndex = 4;
            this.lblFakulte.Text = "Fakülte";
            // 
            // BolumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFakulte);
            this.Controls.Add(this.cmbFakulte);
            this.Controls.Add(this.txtBolumAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBolumEkle);
            this.Name = "BolumEkle";
            this.Text = "BolumEkle";
            this.Load += new System.EventHandler(this.BolumEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.ComboBox cmbFakulte;
        private System.Windows.Forms.Label lblFakulte;
    }
}