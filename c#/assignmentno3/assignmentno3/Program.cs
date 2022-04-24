using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    //*************************Student Marks*********************

    internal class Student
    {
        int rollno;
        String name;
        String branch;
        String semister;
        String class1;

        static public void displayResult()
        {
            Console.WriteLine("*************************Student Marks*********************");
            int[] Studentmarks = new int[5];
            Studentmarks[0] = 90;
            Studentmarks[1] = 70;
            Studentmarks[2] = 80;
            Studentmarks[3] = 90;
            Studentmarks[4] = 90;

            for (int i = 0; i < Studentmarks.Length; i++)
            {
                Console.WriteLine("Marks Of " + i + " Subjects  Are: " + Studentmarks[i]);
            }

            double average = Studentmarks.Average();

            for (int i = 0; i < Studentmarks.Length; i++)
            {
                if (Studentmarks[i] < 35)
                {
                    Console.WriteLine("FAILED");
                }
                else if (Studentmarks[i] > 35 && average < 50)
                {
                    Console.WriteLine("FAILED");
                }
                else if (average > 50)
                {
                    Console.WriteLine("PASSED");
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }
        public Student(int rollno, String name, String branch, String sem, String class2)
        {
            this.rollno = rollno;
            this.name = name;
            this.branch = branch;
            this.semister = sem;
            this.class1 = class2;
            Console.WriteLine($"\n Rollno is: {rollno}, Name is {name},Student class is {class2}, Sem is {sem},Branch is : {branch}");
        }
        static public void displayData()
        {
            Console.WriteLine("\nthe marks: ");
        }
    }

    //***********************Car Details**********************

    internal class Car
    {
        int car_no;
        string car_name;
        string car_type;
        readonly double cost =1000000;
        public Car(int car_no, string car_name, string car_type, double cost)
        {
            this.car_no = car_no;
            this.car_name = car_name;
            this.car_type = car_type;
            this.cost = cost;
            Console.WriteLine("***********************Car Details**********************");
            Console.WriteLine($"\nThe car_no is {car_no},Car_name is {car_name},Car_type is {car_type},Cost is {cost} ");
        }
        public void showDetails()
        {
            Console.WriteLine("\nBefore changing");
            Console.WriteLine($"The car_no is {car_no},Car_name is {car_name},Car_type is {car_type},Cost is {cost} ");
        }
        public Car(double car_cost)
        {
            Console.WriteLine("\nAfter changing");
            car_cost = cost;
            Console.WriteLine($"The car_no is {car_no},Car_name is {car_name},Car_type is {car_type},Cost is {cost} ");

        }
    }

    //**********************bank loan *************************
    
    internal class bank
    {
        double interestRate;
        public void loanCalculator(double loanamt)
        {
            Console.WriteLine("********************** bank loan *************************");
            Console.WriteLine("\nEnter The  Interest");
            interestRate = Convert.ToDouble(Console.ReadLine());
            double interest = (loanamt * interestRate) / 100;
            Console.WriteLine("\nRate of interest for " + interestRate + "(in percentage ) %  is : " + interest);
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //**********************student****************
           
            Student.displayResult();
            Student student = new Student(24, "vamsikrishna", "Mca", "6", "Computer Applications");
            Student.displayData();

            //********************car*********************
           
            Car car = new Car(123, "Audi", "Stylish", 10000000);
            car.showDetails();
            Car car2 = new Car(60000000);

            //***********************bank******************************

           
            bank bank = new bank();
            Console.WriteLine("\nenter the loan amount: ");
            bank.loanCalculator(Convert.ToInt32(Console.ReadLine()));

            Console.ReadLine();


        }
    }
}