using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations.Entities
{
    public class Lecture
    {
        #region Properties

        public int LectureID { get; set; }
        public string LectureCode { get; set; }
        public string LectureName { get; set; }

        #endregion

        #region Relations

        public List<StudentLecture> StudentLectures { get; set; }
        public List<DepartmentLecture> DepartmentLectures { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        #endregion

    }
}
