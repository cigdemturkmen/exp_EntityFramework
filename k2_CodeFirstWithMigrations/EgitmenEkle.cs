using k2_CodeFirstWithMigrations.Entities;
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
    public partial class EgitmenEkle : Form
    {
        public EgitmenEkle()
        {
            InitializeComponent();
        }

        OBSDbContext db = new OBSDbContext();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor()
            {
                Name = txtAd.Text,
                Surname = txtSoyad.Text,
                Telephone = txtTelefon.Text,
                Address = txtAdres.Text,
                
            };

            db.Instructors.Add(instructor);
            int sonuc = db.SaveChanges();

            if (sonuc > 0)
            {
                MessageBox.Show("Eğitmen eklendi");
            }
        }
    }
}

