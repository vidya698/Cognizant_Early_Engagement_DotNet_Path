using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3		//DO NOT CHANGE the namespace
{
	public class Program		//DO NOT CHANGE the class 'Program' name
	{
		public static void Main(string[] args)      //DO NOT CHANGE the 'Main' signature
		{
			//Implement your code here
			string policyType;
			int age;
			
			Console.WriteLine("Enter Policy type");
			policyType = Console.ReadLine();
			
			Console.WriteLine("Enter age");
			age = int.Parse(Console.ReadLine());
			
			if (policyType == "Property" || policyType == "Health")
			{
				if (GetPremiumAmount(age, policyType) != 0)
					Console.WriteLine("The premium amount for your {0} policy is Rs.{1}", policyType, GetPremiumAmount(age, policyType));
				else
					Console.WriteLine("Invalid Input");
			}
			else
				Console.WriteLine("Invalid Input");
		}
		
		//Implement method here and keep the method 'public' and 'static'
		
		public static double GetPremiumAmount(int age, string policyType)
		{
			double amount;
			
			if (policyType == "Property")
			{
				if (age <= 5)
					amount = 5000;
				else if (age > 5 && age <=20)
					amount = 10000;
				else
					amount = 0;
 			}
			else
			{
				if (age <= 30)
					amount = 1000;
				else if (age > 30 && age <=50)
					amount = 3000;
				else
					amount = 0;
			}
			
			return amount;
		}
	}
}