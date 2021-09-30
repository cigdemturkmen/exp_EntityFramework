using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst.Entities
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        [StringLength(40, ErrorMessage ="burası opsiyonel. en fazla 40 karakter girilebilir")]
        public string CompanyName { get; set; }
        public string City { get; set; }

        public List<Product> Products { get; set; } // supplier n product 1
    }
}
