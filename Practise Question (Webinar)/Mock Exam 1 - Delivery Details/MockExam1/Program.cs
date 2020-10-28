using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExam1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Delivery> li = new List<Delivery>();
            Delivery d;

            Console.WriteLine("Enter the number of deliveries :");
            int deliveries = int.Parse(Console.ReadLine());

            long over, ball, runs;
            string nonStricker, bowler, batsman;

            for (int i=0; i<deliveries; i++)
            {
                Console.WriteLine("Enter the over :");
                over = long.Parse(Console.ReadLine());

                Console.WriteLine("Enter the ball :");
                ball = long.Parse(Console.ReadLine());

                Console.WriteLine("Enter the runs :");
                runs = long.Parse(Console.ReadLine());

                Console.WriteLine("Enter the batsman name :");
                batsman = Console.ReadLine();

                Console.WriteLine("Enter the bowlers name :");
                bowler = Console.ReadLine();

                Console.WriteLine("Enter the non-stricker name :");
                nonStricker = Console.ReadLine();

                d = new Delivery(over, ball, runs, nonStricker, batsman, bowler);
                li.Add(d);

                Console.WriteLine();
            }

            int choice;
            while(true)
            {
                Console.WriteLine("\nEnter your choice :");
                Console.WriteLine("1. View Delivery Details");
                Console.WriteLine("2. Batsman and Bowler");
                Console.WriteLine("3. Maximum Runs");

                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("\nDelivery Details\n");
                        DeliveryBO.DisplayAllDeliveryDetails(li);
                        break;

                    case 2:
                        Console.WriteLine("\nEnter the over for which batsman and bowler to be known :");
                        long o = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the ball for which batsman and bowler to be known :\n");
                        long b = long.Parse(Console.ReadLine());
                        DeliveryBO.DisplayBatsmanBowlerDetails(li, b, o);
                        break;

                    case 3:
                        Console.WriteLine();
                        DeliveryBO.DisplayMaximumRunDetails(li);
                        break;

                    default:
                        Console.WriteLine("Wrong Choice, Try again....");
                        break;
                }
            }
        }
    }
}
