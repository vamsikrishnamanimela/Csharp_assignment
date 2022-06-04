using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniprojectStudentmanagement
{
    public class Student
        {
            public int Student_Id { get; set; }
            public string Student_Name { get; set; }
            public string Student_Dob { get; set; }

            public Student(int S_Id, string S_Name, string S_Dob)
            {
             Student_Id = S_Id;
             Student_Name = S_Name;
             Student_Dob = S_Dob;
            }

        }

        public class Course
        {
            public int Course_Id;
            public string Course_Name;
            public int Course_Duration;
            public float Course_Fees;


        public Course(int C_Id, string C_Name, int C_Duration, float C_fees)
        {
            this.Course_Id = C_Id;
            this.Course_Name = C_Name;
            this.Course_Duration = C_Duration;
            this.Course_Fees = C_fees;
        }

    }
    class App
    {
        Info Information = new Info();
        public void Scenario1()
        {
            Student Stu = new Student(100, "Vamsi", "10/12/1990");
            Student Stu1 = new Student(101, "krishna", "16/05/2000");

            Information.DisplayDetails(Stu);
            Information.DisplayDetails(Stu1);
        }

        public void Scenario2()
        {
            Student[] ArrStu = new Student[2];
            ArrStu[0] = new Student(102, "Radha", "15/06/1996");
            ArrStu[1] = new Student(103, "Amala", "20/07/2004");
            for (int i = 0; i < ArrStu.Length; i++)
            {
                Information.DisplayDetails(ArrStu[i]);
                Information.DisplayDetails(ArrStu[i]);

            }
        }

        public void Scenario3()
        {
            Console.WriteLine("Enter How Many  Students You Want.....");
            int No_of_student = Convert.ToInt32(Console.ReadLine());
            Student[] Stu1 = new Student[No_of_student];
            for (int i = 0; i < Stu1.Length; i++)
            {
                Console.WriteLine("Enter The Student Id.....:");
                Console.WriteLine("Enter The Name......:");
                Console.WriteLine("Enter The Student Date of Birth.....:");
                Stu1[i] = new Student(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
            }
            for (int i = 0; i < Stu1.Length; i++)
            {
                Information.DisplayDetails(Stu1[i]);
            }



            }
            static void Main(string[] args)
            {
            App application = new App();

            AppEngine eng = new AppEngine();

            new UserInterFace().showFirstScreen();

            Console.Read();
        //    App ap = new App();
        //    string Choice;
        //    do
        //    {


        //        Console.WriteLine("Select Your Option What You want .....:1 For Scenario1 :2 For Scenario2 :3 For Scenario3");
        //        Console.WriteLine("Choice Your Option 1 OR 2 OR 3..:");
        //        int Option = Convert.ToInt32(Console.ReadLine());

        //        switch (Option)
        //        {
        //            case 1:
        //                ap.Scenario1();
        //                break;
        //            case 2:
        //                ap.Scenario2();
        //                break;
        //            case 3:
        //                ap.Scenario3();
        //                break;
        //            default:
        //                Console.WriteLine("Invalid Choice Select 1 OR 2 OR 3");
        //                break;
        //        }
        //        Console.WriteLine("Do you want to continue Student Page :YES or NO");
        //      Choice = Console.ReadLine().ToUpper();
        //    }
        //    while (Choice == "YES");
        }

            
            }
        }
    

