using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst.Entities
{
    public class Category
    {
        #region Properties

        public int CategoryID { get; set; } // primary key

        //[MaxLength(15, ErrorMessage = "Bu alana en fazla 15 karakter girilebilir")] //attribute - propertynin üzerine tanımlanır
        //[MinLength(5, ErrorMessage = "En az 5 karakter girebilirsiniz")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "en az 5 en fazla 15 karakter girilebilir")]
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        
        //
        #endregion


        #region Relations

        public List<Product> Products { get; set; } 

        #endregion

        #region Methods
        public override string ToString()
        {
            return CategoryName;
        } 
        #endregion
    }
}
