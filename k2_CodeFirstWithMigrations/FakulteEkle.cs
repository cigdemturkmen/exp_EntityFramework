using k2_CodeFirstWithMigrations.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k2_CodeFirstWithMigrations
{
    public partial class FakulteEkle : Form
    {
        //fakülte listesi ekranı yaparak tüm fakülteleri listeleyiniz.
        //fakülte güncellemeyi listeden sağ tık menüsü ile yapalım. seçilen değeri ekleme ekranında yapalım
        public FakulteEkle()
        {
            InitializeComponent();
        }
        OBSDbContext db = new OBSDbContext();

        private void FakulteEkle_Load(object sender, EventArgs e)
        {
            if (DuzenlenecekFakulteID != 0)
            {
                //düzenleme işlemi
                this.Text = "Fakülte Düzenle";

                var duzenlenecekFakulte = db.Faculties.FirstOrDefault(x => x.FacultyID == DuzenlenecekFakulteID);

                if (duzenlenecekFakulte != null)
                {
                    txtFakulteAdi.Text = duzenlenecekFakulte.FacultyName;
                }
            }
            //0 gelirse ekleme işlemidir.
            this.Text = "Fakülte Ekleme";
        }

        public int DuzenlenecekFakulteID { get; set; }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (DuzenlenecekFakulteID != 0)
            {
                //düzenleme kayıt
                var guncellenecekFakulte = db.Faculties.FirstOrDefault(x => x.FacultyID == DuzenlenecekFakulteID);

                if (guncellenecekFakulte != null)
                {
                    guncellenecekFakulte.FacultyName = txtFakulteAdi.Text;
                }
                else
                {
                    MessageBox.Show("Böyle kayıt bulunamadı.");
                }
            }
            else
            {
                //ekleme kayıt
                Faculty faculty = new Faculty();

                faculty.FacultyName = txtFakulteAdi.Text;

                db.Faculties.Add(faculty);
            }


            //Faculty faculty = new Faculty();

            //faculty.FacultyName = txtFakulteAdi.Text;

            //db.Faculties.Add(faculty);

            var sonuc = db.SaveChanges();

            if (sonuc > 0)
            {
                MessageBox.Show("Fakülte başarıyla eklendi");
            }
        }

        private void btnFakulteleriListele_Click(object sender, EventArgs e)
        {
            lvwFakulteler.Items.Clear();

            foreach (var item in db.Faculties)
            {
                lvwFakulteler.Items.Add(item.ToString());
            }

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenFakulteID = Convert.ToInt32(lvwFakulteler.SelectedItems[0].Text);



            var silinecek = db.Faculties.FirstOrDefault(x => x.FacultyID == secilenFakulteID);
            if (silinecek != null)
            {
                db.Faculties.Remove(silinecek);

                int sonuc = db.SaveChanges();

                if (sonuc > 0)
                {
                    MessageBox.Show("Fakülte silindi.");
                }
            }

        }

        private void bölümleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenFakulteID = Convert.ToInt32(lvwFakulteler.SelectedItems[0].Text);

            // Fakulte ID'si 2 olan bölümleri listele.

            var bolumler = db.Departments.Where(x => x.FacultyId == secilenFakulteID).ToList();

            //mb'da sadece bolumlerin adını gösterelim

            string bolumAdlari = "";

            foreach (var item in bolumler)
            {
                bolumAdlari += item.DepartmentName + "\n";
            }

            MessageBox.Show(bolumAdlari);
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var secilenFakulteId = Convert.ToInt32(lvwFakulteler.SelectedItems[0].Text);

            var fakulteDuzenlemeFormu = new FakulteEkle();
            fakulteDuzenlemeFormu.MdiParent = this.MdiParent;
            fakulteDuzenlemeFormu.Name = "frmFakulteDuzenleme";
            fakulteDuzenlemeFormu.WindowState = FormWindowState.Maximized;

            fakulteDuzenlemeFormu.DuzenlenecekFakulteID = secilenFakulteId;

            fakulteDuzenlemeFormu.Show();
        }

       
    }
}
