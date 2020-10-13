using System;

namespace JaggedArray
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the number of teams:");
			int teams = Convert.ToInt32(Console.ReadLine());
			
			int[][] teamsArray = new int[teams][];
			
			for(int i=0; i<teams; i++)
			{
				Console.WriteLine("No.of attempts for team {0}", (i+1));
				int attempt = Convert.ToInt32(Console.ReadLine());
				teamsArray[i] = new int[attempt];
			}
			
			for(int i=0; i<teams; i++)
			{
				Console.WriteLine("Enter the score for team {0}", (i+1));
				for(int j=0; j<teamsArray[i].Length; j++)
					teamsArray[i][j] = Convert.ToInt32(Console.ReadLine());
			}
			
			Console.WriteLine(GetTotalScore(teamsArray));
		}
		
		public static String GetTotalScore(int[][] array)
		{
			String res = "";
			
			for(int i=0; i<array.Length; i++)
			{
				int sum=0;
				for(int j=0; j<array[i].Length; j++)
				{
					sum += array[i][j];
					res += "Team " + (i+1) + " Total Score is " + sum + ". ";
				}
			}
			return res;
		}
	}
}