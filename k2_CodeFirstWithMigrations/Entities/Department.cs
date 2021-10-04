using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations.Entities
{
    public class Department
    {
        #region Properties

        [Key]
        public int DepartmenID { get; set; }
        public string DepartmentName { get; set; }

        #endregion

        #region Relations
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        public List<Student> Students { get; set; }

        public List<DepartmentLecture> DepartmentLectures  { get; set; }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{this.DepartmentName}";
        }
        #endregion
    }
}
