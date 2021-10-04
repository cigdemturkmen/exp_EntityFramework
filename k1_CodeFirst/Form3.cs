using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace k1_CodeFirst
{
    public partial class Form3 : Form
    {
        /*********************** INCLUDE ILE JOIN YAPMA *****************************/
        public Form3()
        {
            InitializeComponent();
        }

        private void btnInclude_Click(object sender, EventArgs e)
        {
            //kategorileri listeleyelim

            NorthwindDbContext db = new NorthwindDbContext();

            //var kategoriler = db.Categories.ToList();

            var kategoriler = db.Categories
                .Include(x => x.Products)
                .ToList();



            //ürünleri listeleyelim

            //var urunler = db.Products.ToList();

            // ürünler - kategoriler arasındaki ilişki 1-n olarak belirtilmişti. supplier-product 1-n
            var urunler = db.Products
                .Include(x => x.Category)
                .Include(x => x.Supplier)
                .ToList(); //include join yapıyor

            var tedarikciler = db.Suppliers.Include(x => x.Products).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NorthwindDbContext db = new NorthwindDbContext();

            var siparisler = db.Orders.Include(x => x.Order_Details).ToList();

            var urunler = db.Products.Include(x => x.Order_Details).ToList();

            var siparisDetaylari = db.Order_Details
                .Include(x => x.Order)
                .Include(x => x.Product)
                .ToList();

            // entity framework bir ORM aracıdır. veri tabanıyla bağlantı kurulduğunda ordaki her şeyin burada nesne olarak tutulduğu bir sistem.
            // ORM : Object Relational Manager
            // Dapper : Dapper da Entity Framework gibi bir ORM. Dapper'da yazdığımız şeyler SQL kodları oluyor ama EF'de SQL kodları yazmadan çekebiliyoruz.
            // Dapper'ın avantajı daha hızlı olması çünkü SQL sorguları direkt çalışıyor. EF'de olduğu gibi kodları sorgu cümlelerine çevirme işlemi yok.
        }
    }
}
