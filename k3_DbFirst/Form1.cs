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

namespace k3_DbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // BOŞ Bİ ŞEKİLDE OBJECT OLUŞTURMAK.. new { ..., ..., ..., ...}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKategorileriGetir_Click(object sender, EventArgs e)
        {
            NorthwindEntities1 db = new NorthwindEntities1();

            // var kategoriler = db.Categories.ToList(); //LazyLoading yaptığı için include etmesek de her defasında bağlı veriler de geldi.

            //Fiyatı 20 ile 50 arasında olan ürünlerin Id, Ürün Adı, Fiyatı, Stok Miktarını ve Kategorisini getiren sorgu

            var sorgu1 = db.Products
                .Include(x => x.Category)
                .Where(x => x.UnitPrice > 20 && x.UnitPrice < 50)
                .Select(x => new
                {
                    UrunID = x.ProductID,
                    UrunAdi = x.ProductName,
                    UrunFiyati = x.UnitPrice,
                    UrunStokMiktari = x.UnitsInStock,
                    KategoriAdi = x.Category.CategoryName,
                    KategoriAciklama = x.Category.Description

                })
                .ToList();

            // Siparişler tablosundan MusteriSirketAdi, CalisanAdiSoyadi, SiparisId, SiparisTarihi ve KargoSirketiAdi getiren sorgu

            var sorgu2 = db.Orders
                .Include(x => x.Customer)
                .Include(x => x.Employee)
                .Select(x => new
                {
                    x.Customer.CompanyName,
                    CalisanAdSoyad = x.Employee.FirstName + " " + x.Employee.LastName,
                    x.OrderID,
                    x.OrderDate,
                    x.ShipVia
                })
                .ToList();

            // CompanyName içerisinde restaurant geçen müşterilerin listelenmesi

            var sorgu3 = db.Customers
                .Where(x => x.CompanyName.Contains("restaurant"))//y string is case-insensitive? cz SQL yüklerken öyle yüklemişim.yoksa şunu da dahil etmeliydim x.CompanyName.Contains("Restaurant")
                .ToList();

            // Çalışanların adını, aoyadını, doğum tarihini ve yaşını getiren sorgu yazınız
          
            var sorgu4 = db.Employees
                .Select(x => new
                {
                    Name = x.FirstName,
                    Surname = x.LastName,
                    Birthdate = x.BirthDate,
                    Age = (DbFunctions.DiffDays(x.BirthDate, DateTime.Now)) / 365 //SqlFunctions.DateDiff
                })
                .ToList();

            dataGridView1.DataSource = sorgu3;
        }
    }
}
