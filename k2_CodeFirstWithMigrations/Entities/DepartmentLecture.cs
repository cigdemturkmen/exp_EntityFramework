using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations.Entities
{
    public class DepartmentLecture
    {
        [Key]
        [Column(Order = 0)]
        public int DepartmentID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int LectureID { get; set; }

        public Lecture Lecture { get; set; }
        public Department Department { get; set; }
    }
}
