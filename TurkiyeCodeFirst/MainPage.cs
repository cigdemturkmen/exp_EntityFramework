using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkiyeCodeFirst
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void msIlEkle_Click(object sender, EventArgs e)
        {
            IlEklemeFormu ilEklemeFormu = new IlEklemeFormu();
            ilEklemeFormu.Show();
        }

        private void msIlleriListele_Click(object sender, EventArgs e)
        {
            IlEklemeFormu ilEklemeFormu = new IlEklemeFormu();
            ilEklemeFormu.Show();
        }

        private void msIlceEkle_Click(object sender, EventArgs e)
        {

        }

        private void msIlceleriListele_Click(object sender, EventArgs e)
        {

        }
    }
}
