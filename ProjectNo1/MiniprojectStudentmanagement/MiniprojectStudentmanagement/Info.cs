using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniprojectStudentmanagement
{
    public class Info
    {
        public void DisplayDetails(Student student)
        {
            Console.WriteLine($" Student Id Is....: {student.Student_Id}, \n Student Name Is....: {student.Student_Name}, \nStudent Dob Is....: {student.Student_Dob}");

        }

        public void DisplayDatails(Course course)
        {
            Console.WriteLine($" Course Id Is....:{course.Course_Id}, \nCourse Name Is....: {course.Course_Name}, \nCourse Duration Is.....: {course.Course_Duration}, \nCourse Fee is....: {course.Course_Fees}");
        }

        public void Display_Enrolldetails(Details_Of_Student_Enroll Enroll)
        {
      
            DisplayDetails(Enroll.Details_Student);
            Display_Details(Enroll.Details_Course);
            Console.WriteLine(Enroll.EDateTime_D);


        }

        private void Display_Details(Course details_Course)
        {
            throw new NotImplementedException();
        }
    }
}