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
    public partial class DersEkle : Form
    {
        public DersEkle()
        {
            InitializeComponent();
        }

        OBSDbContext db = new OBSDbContext(); 

        private void DersEkle_Load(object sender, EventArgs e)
        {
            var egitmenler = db.Instructors.ToList();

            cmbEgitmen.Items.AddRange(egitmenler.ToArray());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var ders = new Lecture()
            {
                LectureName = txtDersAdi.Text,
                LectureCode = txtDersKodu.Text,
                InstructorId = ((Instructor)cmbEgitmen.SelectedItem).InstructorID
            
            };

            int sonuc = db.SaveChanges();

            if (sonuc > 0)
            {
                MessageBox.Show("Ders eklendi");
            }
        }
    }
}
