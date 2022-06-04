using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniprojectStudentmanagement
{
    public class Details_Of_Student_Enroll
    {
        private Student student;
        private Course course;
        private DateTime Enroll_Date;

        public Student Details_Student
        {
            get { return student; }
            set { student = value; }
        }
        public Course Details_Course
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime EDateTime_D
        {
            get { return Enroll_Date; }
            set { Enroll_Date = value; }
        }

        public Details_Of_Student_Enroll(Student student, Course course, DateTime Enroll_Date)
        {
            this.student = student;
            this.course = course;
            this.Enroll_Date = Enroll_Date;

        }
    }
}