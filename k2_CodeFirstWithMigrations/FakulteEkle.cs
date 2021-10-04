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
    public partial class FakulteEkle : Form
    {
        public FakulteEkle()
        {
            InitializeComponent();
        }
        OBSDbContext db = new OBSDbContext();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty();

            faculty.FacultyName = txtFakulteAdi.Text;

            db.Faculties.Add(faculty);

            var sonuc = db.SaveChanges();

            if (sonuc > 0)
            {
                MessageBox.Show("Fakülte başarıyla eklendi");
            }
        }
    }
}
