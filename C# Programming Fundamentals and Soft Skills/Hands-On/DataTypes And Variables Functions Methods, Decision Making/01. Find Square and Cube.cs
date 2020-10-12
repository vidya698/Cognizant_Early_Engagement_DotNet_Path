using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2               //DO NOT Change namespace name
{
    public class Program                //DO NOT Change class 'Program' name
    {
        public static void Main(string[] args)        //DO NOT Change 'Main' method Signature
        {
            //Implement your code here
            Console.WriteLine("Enter a Number");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Square of " + x + " is " + FindSquare(num));
            Console.WriteLine("Cube of " + x + " is " + FindCube(num));
        }
        //Implement methods here. Keep the method 'public' and 'static'
        public static double FindSquare(double num){
            return (num*num);
        }
        public static double FindCube(double num){
            return (num*num*num);
        }
    }
}
