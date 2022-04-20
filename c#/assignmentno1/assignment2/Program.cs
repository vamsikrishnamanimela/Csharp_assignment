using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            Console.WriteLine("Enter the number1:");
            Console.WriteLine("Enter the number2 :");
            number1 =Convert.ToInt32(Console.ReadLine());
            number2 =Convert.ToInt32(Console.ReadLine());
            if (number1==number2)
            {

                Console.WriteLine("{0}and{1} are equal", number1, number2);


                
            }
            checkeven check = new checkeven();
            check.positiveornegative();
            arthmaticopp ar=new arthmaticopp();
            ar.aropp();

            Console.ReadLine();

        }
      

       
        
    }
}

class checkeven
{
    public void positiveornegative()
    {
        int num;
        Console.WriteLine("Enter the number  :");
        num = Convert.ToInt32(Console.ReadLine());
        if (num >= 0)
        {
            Console.WriteLine("positive");

        }
        else
        {
            Console.WriteLine("negative");

        }
    }
}

class arthmaticopp
{
    public void aropp()
    {
        int num1;
        int num2;
        int option;
        
        Console.WriteLine("1 for addition");
        Console.WriteLine("2 for subtraction");
        Console.WriteLine("3 for mul");
        Console.WriteLine("4 for div");
        Console.WriteLine("Select your opration");
        option = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the first number:");
        Console.WriteLine("Enter the second number :");
        num1= Convert.ToInt32(Console.ReadLine());
        num2= Convert.ToInt32(Console.ReadLine());
        if (option == 1)
        {
            Console.WriteLine(num1 + num2);

        }
        else if (option == 2)
        {
            Console.WriteLine(num2 - num1);
        }
        else if (option == 3)
        {
            Console.WriteLine(num1*num2);


        }
        else if (option==4)
        {
            Console.WriteLine(num2 / num1);
        }





    }
}