/*1.Write a console program that uses delegates to call calculator functionalities
    like Addition, Subtraction and Multiplication, by taking 2 integer parameters and 
    returning the added, 
    subtracted and multiplied values. Display the return values accordingly.
*/
using System;
namespace codeBaseExam
{
    public delegate void calculate(int a, int b);



    class Program
    {
        public static void addition(int a, int b)
        {
            int res = a + b;
            Console.WriteLine("Addition result is ....:{0}",res);
        }
        public static void substraction(int a, int b)
        {
            int res = a - b;
            Console.WriteLine("substraction result is....:{0}",res);
        }
        public static void multiplication(int a, int b)
        {
            int res = a * b;
            Console.WriteLine(" multiplicatio result is ....:{0}",res);
        }
      
        static void Main(string[] args)
        {
            calculate obj = new calculate(Program.addition);
            obj.Invoke(22, 25);
            obj = substraction;
            obj(33, 22);
            obj = multiplication;
            obj(44, 55);
            
            Console.ReadLine();
        }
    }
}