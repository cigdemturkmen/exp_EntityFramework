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
    public partial class BolumEkle : Form
    {
        public BolumEkle()
        {
            InitializeComponent();
        }

        OBSDbContext db = new OBSDbContext();

        private void BolumEkle_Load(object sender, EventArgs e)
        {
            var fakulteler = db.Faculties.ToList();

            cmbFakulte.Items.AddRange(fakulteler.ToArray());

            var dersler = db.Lectures.ToList();
            foreach (var item in dersler)
            {
                clbDersler.Items.Add(item);
            }
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            Department department = new Department()
            {
                DepartmentName = txtBolumAdi.Text,
                FacultyId = ((Faculty)cmbFakulte.SelectedItem).FacultyID,
            };

            #region Ara tabloya veri ekleme

            var bolumdekiDersler = new List<DepartmentLecture>();

            foreach (var item in clbDersler.CheckedItems)
            {
                var secilenDers = (Lecture)item;
                var bolumdekiDers = new DepartmentLecture()
                {
                    //DepartmenID burayı EF kaydederken kendisi doldurur
                    LectureID = secilenDers.LectureID
                };

                bolumdekiDersler.Add(bolumdekiDers);
            }

            department.DepartmentLectures = bolumdekiDersler;


            #endregion

            if (!db.Departments.Any(x => x.FacultyId == department.FacultyId && x.DepartmentName == department.DepartmentName))
            {
                db.Departments.Add(department);

                int sonuc = db.SaveChanges();

                if (sonuc > 0)
                {
                    MessageBox.Show("Bölüm eklendi");
                }
            }
            else
            {
                MessageBox.Show("Bu fakültede aynı isimde bir bölüm daha önce eklenmiş.");
            }
        }

        

        private void cmbFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var secilenFakulte = cmbFakulte.SelectedItem;

            //var bolumler = db.Departments.Include( x => x.)

        }
    }
}

