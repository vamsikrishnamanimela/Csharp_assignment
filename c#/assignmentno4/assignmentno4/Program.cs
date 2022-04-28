using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentno4
{
     public abstract class Student
     {
    public  string name { get; set; }
    public   int studentid { get; set; }

         public abstract void Booleanispassed(int grade);

     }
     public class Undergraduate : Student
     {
         public override void Booleanispassed(int grade)
         {

             Console.WriteLine("Enter The  Grade :");
             grade = Convert.ToInt32(Console.ReadLine());

             if (grade > 70)
             {
                 Console.WriteLine("Undergraduate student get Passed");
             }
             else
             {
                 Console.WriteLine("Undergraduate student get Fail");
             }
         }

     }
     public class graduate : Student
     {
         public override void Booleanispassed(int grade)
         {

             Console.WriteLine("Enter The  Grade :");
             grade = Convert.ToInt32(Console.ReadLine());

             if (grade > 80)
             {
                 Console.WriteLine("Graduate student get Passed");
             }
             else
             {
                 Console.WriteLine("Graduate student get Fail");
             }
         }

     }



    public class Students
    {
        public int StudentId;
        public string StudentName;
        public double Examfee;


        public void displayDetails()
        {
            Console.WriteLine("the student name is :{0} id is  : {1} fees paid :{2}",StudentName,StudentId,Examfee);
        }
        public void PayFee()
        {
            Console.WriteLine("Enter The Student Id: ");
            StudentId= int.Parse(Console.ReadLine());
            Console.WriteLine("enter the student name: ");
             StudentName= Console.ReadLine();
            Console.WriteLine("The Exam fees is :" + 1500);
            Console.WriteLine("Enter The Exam Fees Amount : ");
            Examfee= int.Parse(Console.ReadLine());
            double Remaingfee = 1500- Examfee;
            if (Examfee == 1500)
            {
                Console.WriteLine("Your fees due is completed ......");
            }
            else
            {
                Console.WriteLine("Your Remaing fee Balance is ......: " + Remaingfee);
            }
        }
    }
    class DayScholar
    {
        public double Transportfees;

        public DayScholar(double Transportfees)
        {
            this.Transportfees = Transportfees;
            double Remaingfee = 50000 - Transportfees;

            Console.WriteLine("The transport fee is : " + 50000 + "per year ");


            Console.WriteLine("The dayscholar   Paid fee is :{0} & Remaining Fee is.....{1}",Transportfees,Remaingfee);
            Console.WriteLine();
        }

    }
    public class Hosteller
    {
        public double hostelfees;

        public Hosteller(double hostelfees)
        {

            this.hostelfees = hostelfees;

            double Remaingfee = 10000-hostelfees ;
            Console.WriteLine("The Total Hostel  fees..: " + 10000+ "Per one  Year ");

            Console.WriteLine("The dayscholar  paid {0} & remaining fee is {1} ",hostelfees,Remaingfee);
            Console.WriteLine();
        }
    }


    public class Employee
    {
        int Empid;
        string Empname;
        float Salary;

        public Employee(int Empid, string Empname, float Salary)
        {
            this.Empid= Empid;
            this.Empname = Empname;
            this.Salary = Salary;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee name is : {0} Employee id is:{1} Salary of The Employee :{2}",Empname,Empid,Salary);
        }
    }
    public class PartTimeEmployee
    {
        public int wages = 1800;

        public void ParttimeEmployeedetails()
        {
            Console.WriteLine("The parttime employee Getings Wages : {0}" ,wages);
        }
    }






    internal class Program
    {
        static void Main()
        {
             Undergraduate un = new Undergraduate();
             un.Booleanispassed(1);
             un.name = "vamsi";
             un.studentid = 11223;
             Console.WriteLine("Student name is :{0}  and id :{1}", un.name, un.studentid);
            

             graduate  gr = new graduate();
             gr.Booleanispassed(5);
             gr.name = "krishna";
             gr.studentid = 12333;
             Console.WriteLine("Student name is :{0}  and id :{1}", gr.name, gr.studentid);
            Console.WriteLine("First program Execution done");


            Students st = new Students();
            st.PayFee();
            st.displayDetails();
            Console.WriteLine("How much money you want pay dayscholar fee .....: ");
            DayScholar dayScholar = new DayScholar(int.Parse(Console.ReadLine()));
            Console.WriteLine("how much many you want pay hostel fee......: ");
            Hosteller hosteller = new Hosteller(int.Parse(Console.ReadLine()));
            



            Employee em = new Employee(67577, "vamsikrishna", 52365.6f);
            em.DisplayEmployeeDetails();
            PartTimeEmployee pt = new PartTimeEmployee();
            pt.ParttimeEmployeedetails();
            Console.ReadLine();

        }
    }
}
