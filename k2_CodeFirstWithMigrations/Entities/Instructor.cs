using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations.Entities
{
    public class Instructor : Base
    {
        #region Properties

        public int InstructorID { get; set; }

        #endregion

        #region Relations

        public List<Student> Students { get; set; }
        public List<Lecture> Lectures { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{this.Name} {this.Surname}";
        }
        #endregion

    }
}
