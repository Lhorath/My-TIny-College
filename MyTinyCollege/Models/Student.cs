using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTinyCollege.Models
{
    public class Student:Person
    {
        public DateTime EnrollmentDate { get; set; }

        //  1 Student with many enrollments.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        /*
         *  Within the Entity framework, the Enrollments property is cal a navigation property.
         *  Navigation Properties hold other entities that are related to this entity.
         *  In this case, the Enrollments property of a student entity will hold all of the enrollment entities that are related to that student entity.
         *  In other words:
         *      If  a given student row in a database has two related enrollment rows (PK - FK) that student entity's enrollment navigation property will contain those two enrollment entities.
         *  
         *  
         */

    }
}