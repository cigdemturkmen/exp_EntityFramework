using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst.Entities
{
    public class Product
    {
    //properties ve relationsları ayrı regionlarda tut. derli toplu dursun
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public bool Discontinued { get; set; }


        // Relations:
        public int? CategoryID { get; set; } // foreign key -- category id null geçilecekse eğer, int null alamaz; int? yazılır.<nullable int> aynı şey.
        public Category Category { get; set; } //join yapmak için extra yazıldı. ilk satır yeterliydi

        public int? SupplierID { get; set; } //bu sadece supplierID bilgisi ile bağlar
        public Supplier Supplier { get; set; } //bu sayesinde tüm supplier tablosu olduğu gibi bağlanır. supplier nesnesi ile bağlanmış oluyor

        public List<Order_Detail> Order_Details { get; set; }

        //yeni bir formda Product crud işlemlerini yaz (form ProductCrud)
    }
}
