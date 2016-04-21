using System;
using System.Collections.Generic;

namespace MyTinyCollege.Models
{
    public class Department
    {
        public int DepartmentID { get; set; } // PK
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? InstructorID { get; set; } // FK to Instructor

        //  ==========  Navigation  Properties  ==========  //
        public virtual Instructor Administrator { get; set; }
        public virtual ICollection<Course> Courses{ get; set; } // 1 Department to Many Courses.
    }
}