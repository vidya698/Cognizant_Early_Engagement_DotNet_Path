using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadValidator    //Do not change the namespace
{
    public class Program      //Do not change the class name
    {
        static void Main(string[] args)       //Do not change the method signature
        {
            //Implement code here
            Console.WriteLine("Enter the number of people");
            int people = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the total load in the elevator");
            int totalLoad = Convert.ToInt32(Console.ReadLine());
            
            bool res = Validator.ValidateElevatorLoad(totalLoad);
            
            if(res)
                Console.WriteLine("Ready to Go");
            else
                Console.WriteLine("Maximum load Exceeded");
        }
    }
    public class Validator       //Do not change the class name
    {
        public static bool ValidateElevatorLoad(int elevatorLoad)    //Do not change the method signature
        {
            //Implement code here
            if(elevatorLoad <= 1400)
                return true;
            return false;
        }
    }
}
