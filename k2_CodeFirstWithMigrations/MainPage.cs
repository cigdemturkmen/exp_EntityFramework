using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k2_CodeFirstWithMigrations
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void eklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aranilanForm = null;

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "frmFakulteEklemeEkrani")
                {
                    aranilanForm = item;
                }
            }

            if (aranilanForm != null)
            {
                aranilanForm.BringToFront();
            }
            else
            {
                var fakulteEklemeFormu = new FakulteEkle();
                fakulteEklemeFormu.MdiParent = this;
                fakulteEklemeFormu.WindowState = FormWindowState.Maximized;
                fakulteEklemeFormu.Name = "frmFakulteEklemeEkrani";

                fakulteEklemeFormu.Show();

            }
        }
    }
}
