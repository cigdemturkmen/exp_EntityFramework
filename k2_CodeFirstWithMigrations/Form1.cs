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
    public partial class Form1 : Form
    {

        /*
         Üniversite için öğrenci bilgi sistemi uygulaması yaptığınızı düşünün. İNGİLİZCE YAP

        -Ogrenci Student
        -Egitmen Instructor
        -Ders Lecture
        -Fakulte Faculty
        -Bolum Department

        -Öğrenci Eğitmen ilişkisi(danışman eğitmen) 1-n
        -Öğrenci Ders arasında n-n
        -Fakülte ile Bölüm 1-n
        -Bölüm ile Öğrenci 1-n
        -Bölüm ile ders n-n
        -Eğitmen ile ders 1-n
        
        */
        public Form1()
        {
            InitializeComponent();
        }

        OBSDbContext db = new OBSDbContext();

        private void btnFakulteEkle_Click(object sender, EventArgs e)
        {
            Faculty faculty1 = new Faculty()
            {
                FacultyName = "Fen-Edebiyat"
            };

            db.Faculties.Add(faculty1);

            int sonuc = db.SaveChanges();

            if (sonuc > 0)
            {
                MessageBox.Show("Kaydetme yapıldı.");
            }

        }

        private void btnBolmEkle_Click(object sender, EventArgs e)
        {
            Department bolum1 = new Department()
            {
                DepartmentName = "İstatistik",
                FacultyId = 1
            };

            db.Departments.Add(bolum1);

            int sonuc = db.SaveChanges();

            if (sonuc > 0)
            {
                MessageBox.Show("Kaydetme yapıldı.");
            }
        }

        private void btnEgitmenEkle_Click(object sender, EventArgs e)
        {
            Instructor egitmen1 = new Instructor()
            {
                Name = "Mehmet",
                Surname = "Öztürk",
                Address = "Ankara",
                Telephone = "03121231212"
               
            };

            db.Instructors.Add(egitmen1);

            int sonuc = db.SaveChanges();

            if (sonuc > 0)
            {
                MessageBox.Show("Kaydetme yapıldı.");
            }
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = "Ayşe",
                Surname = "Yılmaz",
                Address = "Ankara",
                Telephone = "03122500938",
                DepartmentId = 1,
                TCKN = "23443223443",
                StudentNumber = "123",
                ConsultantInstructorId = 1
            };

            db.Students.Add(student);

            int sonuc = db.SaveChanges();

            if (sonuc > 0)
            {
                MessageBox.Show("Kaydetme yapıldı.");
            }

        }
    }
}
