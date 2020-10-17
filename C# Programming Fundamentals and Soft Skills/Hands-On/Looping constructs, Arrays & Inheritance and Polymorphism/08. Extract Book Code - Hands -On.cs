using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Substring(Int32)	
Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.

Substring(Int32, Int32)	
Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.

*/

namespace ExtractBookCode      //Do not change the namespace name
{
    public class Program      //Do not change the class name
    {
        public static void Main(String[] arg)         //Do not change the method signature
        {
            //Implement code here
            string bookCode;
            
            Console.WriteLine("Enter the book code of length 18");
            bookCode = Console.ReadLine();
            
            if (bookCode.Length == 18)
            {
                if(bookCode.Substring(0,3) == "101" || bookCode.Substring(0,3) == "102" || bookCode.Substring(0,3) == "103")
                    Console.WriteLine("Department Code : {0}", bookCode.Substring(0,3));
                else
                    Console.WriteLine(" Invalid Department Code");
                    
                int year = Convert.ToInt32(bookCode.Substring(3,4));
                if(year>=1900 && year<=2020)
                    Console.WriteLine("Year of Publication : {0}", year);
                else
                    Console.WriteLine("Invalid Year");
                    
                long pages = Int64.Parse(bookCode.Substring(7,5));
                if(pages >= 00001 && pages<=99999)
                    Console.WriteLine("Number of Pages : {0}", pages);
                else
                    Console.WriteLine("Invalid Page Numbers");
                    
                char ch = Convert.ToChar(bookCode.Substring(12,1));
                if(Char.IsLetter(ch))
                {
                    if(Char.IsNumber(Convert.ToChar(bookCode.Substring(13,1))) && Char.IsNumber(Convert.ToChar(bookCode.Substring(14,1))) && Char.IsNumber(Convert.ToChar(bookCode.Substring(15,1))) && Char.IsNumber(Convert.ToChar(bookCode.Substring(16,1))) && Char.IsNumber(Convert.ToChar(bookCode.Substring(17,1))))
                    {
                        Console.WriteLine("Book ID : " + bookCode.Substring(12,6));
                    }
                } else
                {
                    Console.WriteLine("Invalid Book ID");
                }
            }
            else
                Console.WriteLine("Invalid Book Code");
        }
    }
}