using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations
{
    public class Neighborhood
    {
        #region Properties

        public int NeighborhoodID { get; set; }
        public string NeighborhoodName { get; set; }
        public string ChiefName { get; set; }
        public string ChiefSurname { get; set; }

        #endregion

        #region Relations

        public int DistrictId { get; set; }
        //public District District { get; set; }

        #endregion


    }
}
