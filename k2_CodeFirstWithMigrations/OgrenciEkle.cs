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
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        OBSDbContext db = new OBSDbContext();

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            var egitmenler = db.Instructors.ToList();

            cmbDanisman.Items.AddRange(egitmenler.ToArray());

            //foreach (var item in egitmenler)
            //{
            //    cmbDanisman.Items.Add(item);
            //}

            var bolumler = db.Departments.ToList();

            cmbBolum.Items.AddRange(bolumler.ToArray());
        }

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txtAd.Text;
            student.Surname = txtSoyad.Text;
            student.StudentNumber = txtOgrenciNo.Text;
            student.TCKN = mtxtTCKN.Text;
            student.DepartmentId = ((Department)cmbBolum.SelectedItem).DepartmenID;
            student.ConsultantInstructorId = ((Instructor)cmbDanisman.SelectedItem).InstructorID;
            student.Telephone = txtTelefon.Text;
            student.Address = txtAdres.Text;

            if (!db.Students.Any(x => x.TCKN == student.TCKN)) //tabloda aynı TC yoksa ekle
            {
                db.Students.Add(student);

                int sonuc = db.SaveChanges();

                if (sonuc > 0)
                {
                    MessageBox.Show("Öğrenci eklendi");
                }
            }
            else
            {
                MessageBox.Show("Bu tckn'ye sahip öğrenci daha önce eklenmiş.");
            }
            

           
        }
    }
}
