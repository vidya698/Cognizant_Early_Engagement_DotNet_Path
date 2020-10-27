using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Score      //DO NOT CHANGE the namespace
{
    public class Program        //DO NOT CHANGE the class name
    {
        public static void Main(string[] args)      //DO NOT CHANGE the 'Main' signature
        {
            //Implement your code here
            int B = 0, D = 0, T = 0;
            int n = 6;

            string[] arr = new string[10];

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Player Name : ");
                arr[i] = Console.ReadLine();
            }

            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] == "Bill")
                    B++;

                if (arr[i] == "Bill" && arr[i] == arr[i+1])
                    B++;

                if (arr[i] == "Tommy")
                    T++;

                if (arr[i] == "Tommy" && arr[i] == arr[i + 1])
                    T++;

                if (arr[i] == "Daisy")
                    D++;

                if (arr[i] == "Daisy" && arr[i] == arr[i + 1])
                    D++;
            }

            Console.WriteLine($"Bill Score : {B}");
            Console.WriteLine($"Tommy Score : {T}");
            Console.WriteLine($"Daisy Score : {D}");
        }   
    }
}