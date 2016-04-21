using System.Collections.Generic;

namespace MyTinyCollege.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; } // FK to Department

        //  ==========  Navigation  Properties  ==========  //
        public virtual ICollection<Enrollment> Enrollments{ get; set; } // 1 Course to Many Enrollments.
        public virtual ICollection<Instructor> Instructors{ get; set; } // 1 Course to Many Instructors.
        public virtual Department Department { get; set; } // Course belongs to a department.

        // Combine Course ID and Title in one Property.
        public string CourseIdTitle
        {
            get
            {
                return CourseID + ": " + Title;
            }
        }
    }
}