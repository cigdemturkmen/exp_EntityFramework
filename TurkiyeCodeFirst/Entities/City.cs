using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkiyeCodeFirst.Entities
{
    public class City
    {
        #region Properties

        [Key]
        public int CityID { get; set; }
        [Required]
        public string CityName { get; set; }
        [Required]
        public string PlateCode { get; set; }
        [Required]
        public string AreaCode { get; set; }

        #endregion

        #region Relations

        public List<District> Districts { get; set; }

        #endregion
    }
}
