
namespace k2_CodeFirstWithMigrations
{
    partial class FakulteListeleme
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
            this.btnFakulteleriListele = new System.Windows.Forms.Button();
            this.lvwFakulteler = new System.Windows.Forms.ListView();
            this.lviFacultyID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviFacultyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFakulteleriListele
            // 
            this.btnFakulteleriListele.Location = new System.Drawing.Point(336, 351);
            this.btnFakulteleriListele.Name = "btnFakulteleriListele";
            this.btnFakulteleriListele.Size = new System.Drawing.Size(149, 23);
            this.btnFakulteleriListele.TabIndex = 7;
            this.btnFakulteleriListele.Text = "Fakülteleri Listele";
            this.btnFakulteleriListele.UseVisualStyleBackColor = true;
            this.btnFakulteleriListele.Click += new System.EventHandler(this.btnFakulteleriListele_Click);
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
            this.lvwFakulteler.Location = new System.Drawing.Point(118, 77);
            this.lvwFakulteler.MultiSelect = false;
            this.lvwFakulteler.Name = "lvwFakulteler";
            this.lvwFakulteler.Size = new System.Drawing.Size(564, 259);
            this.lvwFakulteler.TabIndex = 6;
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
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // FakulteListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFakulteleriListele);
            this.Controls.Add(this.lvwFakulteler);
            this.Name = "FakulteListeleme";
            this.Text = "FakulteListeleme";
            this.Load += new System.EventHandler(this.FakulteListeleme_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFakulteleriListele;
        private System.Windows.Forms.ListView lvwFakulteler;
        private System.Windows.Forms.ColumnHeader lviFacultyID;
        private System.Windows.Forms.ColumnHeader lviFacultyName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}