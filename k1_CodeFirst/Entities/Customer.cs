using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst.Entities
{
    public class Customer
    {
        #region Properties

        [Required(ErrorMessage = "Bu alanın oluşturulması zorunludur.")]
        [MaxLength(5, ErrorMessage = "Oluşturulan ID 5 karakterli olmalıdır. ")]
        [MinLength(5, ErrorMessage = "Oluşturulan ID 5 karakterli olmalıdır.")]
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        #endregion

        #region Relations

        public List<Order> Orders { get; set; }

        #endregion
    }
}
