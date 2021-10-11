
namespace TurkiyeCodeFirst
{
    partial class MainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msIlIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.msIlEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.msIlleriListele = new System.Windows.Forms.ToolStripMenuItem();
            this.msIlceIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.msIlceEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.msIlceleriListele = new System.Windows.Forms.ToolStripMenuItem();
            this.msMahalleIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.msMahalleEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.msMahalleleriListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msIlIslemleri,
            this.msIlceIslemleri,
            this.msMahalleIslemleri});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msIlIslemleri
            // 
            this.msIlIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msIlEkle,
            this.msIlleriListele});
            this.msIlIslemleri.Name = "msIlIslemleri";
            this.msIlIslemleri.Size = new System.Drawing.Size(91, 24);
            this.msIlIslemleri.Text = "İl işlemleri";
            // 
            // msIlEkle
            // 
            this.msIlEkle.Name = "msIlEkle";
            this.msIlEkle.Size = new System.Drawing.Size(224, 26);
            this.msIlEkle.Text = "İl Ekle";
            this.msIlEkle.Click += new System.EventHandler(this.msIlEkle_Click);
            // 
            // msIlleriListele
            // 
            this.msIlleriListele.Name = "msIlleriListele";
            this.msIlleriListele.Size = new System.Drawing.Size(224, 26);
            this.msIlleriListele.Text = "İlleri Listele";
            this.msIlleriListele.Click += new System.EventHandler(this.msIlleriListele_Click);
            // 
            // msIlceIslemleri
            // 
            this.msIlceIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msIlceEkle,
            this.msIlceleriListele});
            this.msIlceIslemleri.Name = "msIlceIslemleri";
            this.msIlceIslemleri.Size = new System.Drawing.Size(106, 24);
            this.msIlceIslemleri.Text = "İlçe İşlemleri";
            // 
            // msIlceEkle
            // 
            this.msIlceEkle.Name = "msIlceEkle";
            this.msIlceEkle.Size = new System.Drawing.Size(224, 26);
            this.msIlceEkle.Text = "İlçe Ekle";
            this.msIlceEkle.Click += new System.EventHandler(this.msIlceEkle_Click);
            // 
            // msIlceleriListele
            // 
            this.msIlceleriListele.Name = "msIlceleriListele";
            this.msIlceleriListele.Size = new System.Drawing.Size(224, 26);
            this.msIlceleriListele.Text = "İlçeleri Listele";
            this.msIlceleriListele.Click += new System.EventHandler(this.msIlceleriListele_Click);
            // 
            // msMahalleIslemleri
            // 
            this.msMahalleIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMahalleEkle,
            this.msMahalleleriListele});
            this.msMahalleIslemleri.Name = "msMahalleIslemleri";
            this.msMahalleIslemleri.Size = new System.Drawing.Size(136, 24);
            this.msMahalleIslemleri.Text = "Mahalle İşlemleri";
            // 
            // msMahalleEkle
            // 
            this.msMahalleEkle.Name = "msMahalleEkle";
            this.msMahalleEkle.Size = new System.Drawing.Size(212, 26);
            this.msMahalleEkle.Text = "Mahalle Ekle";
            // 
            // msMahalleleriListele
            // 
            this.msMahalleleriListele.Name = "msMahalleleriListele";
            this.msMahalleleriListele.Size = new System.Drawing.Size(212, 26);
            this.msMahalleleriListele.Text = "Mahalleleri Listele";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msIlIslemleri;
        private System.Windows.Forms.ToolStripMenuItem msIlEkle;
        private System.Windows.Forms.ToolStripMenuItem msIlleriListele;
        private System.Windows.Forms.ToolStripMenuItem msIlceIslemleri;
        private System.Windows.Forms.ToolStripMenuItem msIlceEkle;
        private System.Windows.Forms.ToolStripMenuItem msIlceleriListele;
        private System.Windows.Forms.ToolStripMenuItem msMahalleIslemleri;
        private System.Windows.Forms.ToolStripMenuItem msMahalleEkle;
        private System.Windows.Forms.ToolStripMenuItem msMahalleleriListele;
    }
}