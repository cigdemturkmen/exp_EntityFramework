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
    public partial class Form1 : Form
    {
        /*
        EntityFramework Code First
           SQL > C#
         Table > Class
        Column > Property


        NuGet Package Manager > entityframework 6 yükle (.net framwork'le bu çalışıyor. core için entityframework core kullanılıyor)

        DbContext'den miras alan veritabanı contextini oluştur

        connection string belirle

        */
        public Form1()
        {
            InitializeComponent();
        }

        // KATEGORİ LİSTELE
        private void btnTest_Click(object sender, EventArgs e)
        {
            NorthwindDBContext db = new NorthwindDBContext();
            List<Category> kategoriler = db.Categories.ToList();

            // Diğer tabloları da bağlayınız:

            //List<Product> urunler = db.Products.ToList(); bunları ayrı formda yazdım.

            //List<Customer> musteriler = db.Customers.ToList();
        }

        // KATEGORİ EKLE
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            // Kategoriler tablosuna  yeni bir kayıt ekleyelim.

            Category yeniKategori = new Category()
            {
                CategoryName = "Meşrubat",
                Description = "İçecek ürünlerin bulunacağı bir kategori",
            };

            NorthwindDBContext db = new NorthwindDBContext();
            db.Categories.Add(yeniKategori);
            var sonuc = db.SaveChanges(); // bunu yazdığın an veritabanına kaydolur yapılan değişiklikler //sonuc int 1

            if (sonuc > 0)
            {
                MessageBox.Show($"Kategori eklendi.Eklenen kategorinin id'si {yeniKategori.CategoryID}");
            }
        }

        // KATEGORİ GÜNCELLE
        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            //kullanıcıdan alınan değerin uzunluğunun 15'den büyük olmasını engellemeniz lazım.
            NorthwindDBContext db = new NorthwindDBContext();

            Category guncellenecekKategori = db.Categories.FirstOrDefault(x => x.CategoryID == 5);

            if (guncellenecekKategori != null) //null check
            {
                guncellenecekKategori.CategoryName = "Grains/Meat"; //truncate hatası, karakter limiti aşıldığı için.
                guncellenecekKategori.Description = "yeni güncelledik";

                int sonuc = db.SaveChanges(); //veri tabanında kaç satır etkilendiyse o kadar değer döner

                if (sonuc > 0)
                {
                    MessageBox.Show("Kategori güncellendi.");
                }
            }
        }

        // KATEGORİ SİL
        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            // bir önceki adımda eklediğin kategoriyi sil

            NorthwindDBContext db = new NorthwindDBContext();

            var silinecekKategori = db.Categories.FirstOrDefault(x => x.CategoryID == 17);

            
            if (silinecekKategori != null) // null check
            {
                db.Categories.Remove(silinecekKategori);
                int sonuc = db.SaveChanges();

                if (sonuc >0)
                {
                    MessageBox.Show("Silme işlemi başarılı");
                }
            }




        }
    }
}
