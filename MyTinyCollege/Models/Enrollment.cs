﻿namespace MyTinyCollege.Models
{
    // Grade enum
    public enum Grade
    {
        A, B, C, D, E, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; } // PK
        public int CourseID { get; set; } // FK to Course
        public int StudentID { get; set; } // FK to Student

        public Grade? Grade { get; set; } // ? in this case means optional (nullable)
        public virtual Student student { get; set; } // Many enrollments to 1 student
        public virtual Course course { get; set; } // Many enrollments to 1 Course
    }
}