using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations.Entities
{
    public class StudentLecture
    {
        [Key]
        [Column(Order = 0)]
        public int StudentID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int LectureID { get; set; }

        public Student Student { get; set; }
        public Lecture Lecture { get; set; }
    }
}
