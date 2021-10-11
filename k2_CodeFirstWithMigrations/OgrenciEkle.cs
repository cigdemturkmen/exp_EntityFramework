using k2_CodeFirstWithMigrations.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

            //var bolumler = db.Departments.ToList(); // bolumler ilgili bu kısmı yoruma aldık çünkü, fakulte seçildikten sonra bolum comboboxı dolacak

            //cmbBolum.Items.AddRange(bolumler.ToArray());

            var fakulteler = db.Faculties.ToList();
            cmbFakulte.Items.AddRange(fakulteler.ToArray());
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

            #region Ara tabloya veri ekleme (ogrenci - ders ara tablosunu dolduralım)

            var ogrecininSectigiDersler = new List<StudentLecture>();

            foreach (var item in clbOgrencininDersleri.CheckedItems)
            {
                var secilenDers = (Lecture)item;
                var ogrencininDersi = new StudentLecture()
                {
                    LectureID = secilenDers.LectureID
                };

                ogrecininSectigiDersler.Add(ogrencininDersi);
            }

            student.StudentLectures = ogrecininSectigiDersler;

            #endregion

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



        private void cmbFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBolum.Items.Clear();
            //Fakülte seçilince bolumler combobox'ına ilgili bölümler gelsin.

            var secilenFakulte = (Faculty)cmbFakulte.SelectedItem;

            //var fakultedekiDersler = db.Faculties  //niye burdan gidiyosun ki!?
            //    .Include(x => x.Departments)
            //    .Where(x => x.FacultyID == secilenFakulte.FacultyID)
            //    .Select(x => x.Departments)
            //    .ToList();

            var bolumler = db.Departments.Where(x => x.FacultyId == secilenFakulte.FacultyID).ToList();

            foreach (var item in bolumler)
            {
                cmbBolum.Items.Add(item);
            }
        }



        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilenBolum = (Department)cmbBolum.SelectedItem;

            //bu bölümdeki dersleri getirelim

            var bolumdekiDersler = db.DepartmentLectures
                .Include(x => x.Lecture)
                .Where(x => x.DepartmentID == secilenBolum.DepartmenID)
                .Select(x => x.Lecture)
                .ToList();

            foreach (var item in bolumdekiDersler)
            {
                clbOgrencininDersleri.Items.Add(item);
            }

        }

    }
}
