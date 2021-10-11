
namespace k2_CodeFirstWithMigrations
{
    partial class FakulteEkle
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
            this.components = new System.ComponentModel.Container();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFakulteAdi = new System.Windows.Forms.TextBox();
            this.lvwFakulteler = new System.Windows.Forms.ListView();
            this.lviFacultyID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviFacultyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFakulteleriListele = new System.Windows.Forms.Button();
            this.bölümleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(119, 112);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 28);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fakülte Adı";
            // 
            // txtFakulteAdi
            // 
            this.txtFakulteAdi.Location = new System.Drawing.Point(119, 80);
            this.txtFakulteAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFakulteAdi.Name = "txtFakulteAdi";
            this.txtFakulteAdi.Size = new System.Drawing.Size(132, 22);
            this.txtFakulteAdi.TabIndex = 2;
            // 
            // lvwFakulteler
            // 
            this.lvwFakulteler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lviFacultyID,
            this.lviFacultyName});
            this.lvwFakulteler.ContextMenuStrip = this.contextMenuStrip1;
            this.lvwFakulteler.FullRowSelect = true;
            this.lvwFakulteler.GridLines = true;
            this.lvwFakulteler.HideSelection = false;
            this.lvwFakulteler.Location = new System.Drawing.Point(401, 80);
            this.lvwFakulteler.MultiSelect = false;
            this.lvwFakulteler.Name = "lvwFakulteler";
            this.lvwFakulteler.Size = new System.Drawing.Size(564, 259);
            this.lvwFakulteler.TabIndex = 3;
            this.lvwFakulteler.UseCompatibleStateImageBehavior = false;
            this.lvwFakulteler.View = System.Windows.Forms.View.Details;
            // 
            // lviFacultyID
            // 
            this.lviFacultyID.Text = "Faculty ID";
            this.lviFacultyID.Width = 135;
            // 
            // lviFacultyName
            // 
            this.lviFacultyName.Text = "Faculty Name";
            this.lviFacultyName.Width = 177;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.bölümleriListeleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 76);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // btnFakulteleriListele
            // 
            this.btnFakulteleriListele.Location = new System.Drawing.Point(619, 354);
            this.btnFakulteleriListele.Name = "btnFakulteleriListele";
            this.btnFakulteleriListele.Size = new System.Drawing.Size(149, 23);
            this.btnFakulteleriListele.TabIndex = 5;
            this.btnFakulteleriListele.Text = "Fakülteleri Listele";
            this.btnFakulteleriListele.UseVisualStyleBackColor = true;
            this.btnFakulteleriListele.Click += new System.EventHandler(this.btnFakulteleriListele_Click);
            // 
            // bölümleriListeleToolStripMenuItem
            // 
            this.bölümleriListeleToolStripMenuItem.Name = "bölümleriListeleToolStripMenuItem";
            this.bölümleriListeleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.bölümleriListeleToolStripMenuItem.Text = "Bölümleri Listele";
            this.bölümleriListeleToolStripMenuItem.Click += new System.EventHandler(this.bölümleriListeleToolStripMenuItem_Click);
            // 
            // FakulteEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnFakulteleriListele);
            this.Controls.Add(this.lvwFakulteler);
            this.Controls.Add(this.txtFakulteAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FakulteEkle";
            this.Text = "FakulteEkle";
            this.Load += new System.EventHandler(this.FakulteEkle_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFakulteAdi;
        private System.Windows.Forms.ListView lvwFakulteler;
        private System.Windows.Forms.ColumnHeader lviFacultyID;
        private System.Windows.Forms.ColumnHeader lviFacultyName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnFakulteleriListele;
        private System.Windows.Forms.ToolStripMenuItem bölümleriListeleToolStripMenuItem;
    }
}