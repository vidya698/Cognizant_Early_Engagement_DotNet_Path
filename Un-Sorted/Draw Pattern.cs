using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals4		//DO NOT CHANGE the namespace
{
	public class Program		//DO NOT CHANGE the class 'Program' name
	{
		public static void Main(string[] args)      //DO NOT CHANGE the 'Main' signature
		{
			string symbol;
			int num;
			
			Console.WriteLine("Enter any symbol $ or * or @ ");
			symbol = Console.ReadLine();
			
			Console.WriteLine("Enter the number of repeats :");
			num = int.Parse(Console.ReadLine());
			
			int k = (int)(num/1)+1;
			
			for( int i=0; i<k; i++)
			{
				for( int j=0; j<k-i-1; j++)
					Console.WriteLine(" ");
				
				for( int j=0; j<(2*i)+1; j++)
						Console.WriteLine(symbol);
					
				for( int j=0; j<k-i-1; j++)
					Console.WriteLine(" ");
				
				Console.WriteLine();
			}
		}
	}
}