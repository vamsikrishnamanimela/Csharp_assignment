using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniprojectStudentmanagement
{
    class UserInterFace : IUserinterface
    { 
        AppEngine eng = new AppEngine();

        string Choice;
        public void showFirstScreen()
        {
            do
            {


                Console.WriteLine("Select Your Option What You want .....:\n1 For Student\n2 For Admin");
                Console.WriteLine("Choice Your Option 1 OR 2..:");
                int Option = Convert.ToInt32(Console.ReadLine());

                switch (Option)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:
                        showAdminScreen();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice Select 1 OR 2");
                        break;
                }
                Console.WriteLine("Do you want to continue Student Page :YES or NO");
                Choice = Console.ReadLine().ToUpper();
            }
            while (Choice == "YES");
        }

        public void showStudentScreen()
        {
            do
            {
                Console.WriteLine("1 For Check Your Existing User....:");
                Console.WriteLine("2 For Register New User....:");
                Console.WriteLine("3 For Search Your Available Courses.....:");
                Console.WriteLine("4 For Enroll to Course....:");

                int Option = Convert.ToInt32(Console.ReadLine());
                switch (Option)
                {
                    case 1:

                        eng.Fatch_Only_One_Student();
                        Console.WriteLine("Execution completed....*");
                        break;
                    case 2:
                        this.showStudentRegistrationScreen();
                        Console.WriteLine("Execution Completed....*");
                        break;
                    case 3:

                        eng.Details_Course_List();
                        Console.WriteLine("Execution  Completed  ....*");
                        break;
                    case 4:

                        eng.Enroll_Insert();
                        Console.WriteLine("Successfully Inserted Enroll Records....*");
                        break;
                    default:
                        Console.WriteLine("Invalid Option Choose Your Option Like 1 OR 2 OR 3 OR 4....");
                        break;
                }
                Console.WriteLine("You Want  Continue   Student Application...:YES OR NO");
                Choice = Console.ReadLine().ToUpper();
            } while (Choice == "YES"); 
        }
        public void showAdminScreen()
        {
            do
            {
                Console.WriteLine("1 For Inserting  New Course.....:");
                Console.WriteLine("2 For It Will Show Available Course...:");
                Console.WriteLine("3 For Update Your  Course Details....:");
                Console.WriteLine("4 For Fatch The Particular Course In The Table....:");
                 Console.WriteLine("5 For Deleting Already Existing Student.....:");
                Console.WriteLine("6 For Delete Particular  Course.....:");
                Console.WriteLine("7 For Update Particular Student Details....:");
                Console.WriteLine("8 For Display all  Registered Students.....:") ;
                int Option = Convert.ToInt32(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        this.introduceNewCourseScreen();
                        Console.WriteLine("Execution Completed.....*");
                        break;
                    case 2:
                        showAllCoursesScreen();
                        Console.WriteLine("Execution  Completed .....*");
                        break;
                    case 3:
                       
                        eng.Update_The_Course();
                        Console.WriteLine("Execuion  Completed .....*");
                        break;
                    case 4:
                        
                        eng.Fatch_Only_One_Student();
                        Console.WriteLine("Execution Completed .....*");
                        break;
                    case 5:
                        eng.Delete_Perticular_Student();
                        Console.WriteLine("Execution Completed .....*");
                        break;
                    case 6:
                       
                        eng.Delete_Perticular_Course();
                        Console.WriteLine("Execution Completed .....*");
                        break;
                    case 7:
                        
                        eng.Update_Student_Details();
                        Console.WriteLine("Execution  Completed.....*");
                        break;
                    case 8:
                       
                        showAllStudentsScreen();
                        break;

                    default:
                        Console.WriteLine("Invalid Option plese Enter Like 1 OR 2 OR 3 OR 4 OR 5 OR 6 OR 7 OR 8....!");
                        break;
                }
                Console.WriteLine(" You Want Continue Admin Page:YES OR NO");
                Choice = Console.ReadLine().ToUpper();
            } while (Choice == "YES");

        }
        public void showAllStudentsScreen()
        {
            Console.WriteLine(" All The  Student Details....:");
            eng.Details_Of_Student();
        }
        public void showStudentRegistrationScreen() 
        {
          
            Console.WriteLine("Enter The StudentId.....:");
            int StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Student Name...:");
            string StudentName = Console.ReadLine();
            Console.WriteLine("Enter The Student DOB.....:");
            string StudentDob = Console.ReadLine();
            eng.Student_Insert(new Student(StudentId, StudentName, StudentDob));
        }

        public void introduceNewCourseScreen()
        {
            eng.Course_Insert();
        }
        public void showAllCoursesScreen()
        {
            Console.WriteLine("All Course Details.....: ");
            eng.Details_Course_List();
        }
    }
}