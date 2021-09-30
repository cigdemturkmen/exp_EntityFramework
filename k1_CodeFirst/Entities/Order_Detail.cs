using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst.Entities
{
    [Table("Order Details")] // veri tabanında görünecek isim bu 
    public class Order_Detail // ama ben bu ismi kullanacağım
    {
        [Key]// ara tabloda hangisinin key olduğunu anlamak için key koyuyoruz.// max length min length vs validaston için yapılır. table'ler ve key'ler
             // 
        [Column(Order = 0)]
        public int OrderID { get; set; }
        public Order Order { get; set; }
        [Key]
        [Column(Order = 1)]
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; } //smallint
        public float Discount { get; set; } //real

        // tinyint - byte
        // smallint - short
        // int - int
        // bigint - long
        // money - decimal
    }
}
