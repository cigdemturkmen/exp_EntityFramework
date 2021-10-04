using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations.Entities
{
    public class Student : Base
    {
        #region Properties

        public int StudentID { get; set; }
        public string StudentNumber { get; set; }
        public string TCKN { get; set; }

        #endregion

        #region Relations

        public int ConsultantInstructorId { get; set; }
        public Instructor ConsultantInstuctor { get; set; }

        public List<StudentLecture> StudentLectures { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        #endregion

    }
}
