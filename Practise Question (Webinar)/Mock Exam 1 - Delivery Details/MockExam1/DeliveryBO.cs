using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExam1
{
    public class DeliveryBO
    {
        public static void DisplayAllDeliveryDetails(List<Delivery> deliveryList)
        {
            Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5}", "Over", "Ball", "Runs", "NonStriker", "Batsman", "Bowler");

            foreach (var item in deliveryList)
                Console.WriteLine(item);
        }

        public static void DisplayBatsmanBowlerDetails(List<Delivery> deliveryList, long ball, long over)
        {
            var res = deliveryList.Where(x => x.Ball == ball && x.Over == over).ToList();

            if(res.Count > 0)
            {
                foreach(var val in res)
                {
                    Console.WriteLine($"\nBatsman : {val.Batsman}");
                    Console.WriteLine($"Bowler : {val.Bowler}");
                }
            }
            else
            {
                Console.WriteLine("Searched Ball or Over does not exist in Collection");
            }
        }

        public static void DisplayMaximumRunDetails(List<Delivery> deliveryList)
        {
            //var maxRuns = deliveryList.Max(x => x.Runs);
            //var res = deliveryList.Where(x=>x.Runs == maxRuns);

            var res = deliveryList.Where(x => x.Runs == deliveryList.Max(y => y.Runs)).FirstOrDefault();
            
            if (res != null)
            {
                Console.WriteLine($"\nMaximum Runs : {res.Runs}");
                Console.WriteLine($"Over : {res.Over}");
                Console.WriteLine($"Ball : {res.Ball}");
            }
        }
    }
}