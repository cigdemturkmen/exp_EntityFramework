using k1_CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k1_CodeFirst
{
    public partial class ProductCrud : Form
    {
        public ProductCrud()
        {
            InitializeComponent();
        }

        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            NorthwindDbContext db = new NorthwindDbContext();

            List<Product> urunler = db.Products.ToList();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Product yeniUrun = new Product()
            {
                ProductName = "Aplle",
                UnitPrice = 12m,
                UnitsInStock = 20,
                Discontinued = false
            };

            NorthwindDbContext db = new NorthwindDbContext();

            db.Products.Add(yeniUrun);

            var sonuc = db.SaveChanges();

            if (sonuc > 0)
            {
                MessageBox.Show($"Ürün başarıyla eklendi. Eklenen ürünün id'si {yeniUrun.ProductID}");
            }

        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            NorthwindDbContext db = new NorthwindDbContext();

            Product guncellenecekkUrun = db.Products.FirstOrDefault(x => x.ProductName == "Apple");

            if (guncellenecekkUrun != null)
            {
                guncellenecekkUrun.UnitPrice = 10m;

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Güncelleme yapıldı.");
                }
            }
        }

        private void btnUrunSilme_Click(object sender, EventArgs e)
        {
            NorthwindDbContext db = new NorthwindDbContext();

            var silinecekUrun = db.Products.FirstOrDefault(x => x.ProductID == 17);


            if (silinecekUrun != null) // null check
            {
                db.Products.Remove(silinecekUrun); // hard delete(uçurmak) - soft delete(IsActive columu bit(tipinde) 1den 0a dönüyor) biz soft tercih ediyoruz.
                //silinecekUrun.Discontinued = false;  //soft delete. gerçekten bir şey silmez. IsActive column'u truedan false dönüyor .

                int sonuc = db.SaveChanges();

                if (sonuc > 0)
                {
                    MessageBox.Show("Silme işlemi başarılı"); //relational olduğu için silmeyecek. hata verecek.
                }
            }
        }
    }
}
