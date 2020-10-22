using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillAutomation
{
    public class ElectricityBill
    {
        private const string Msg = "Invalid Consumer Number";
        private String consumerNumber;
        private String consumerName;
        private int unitsConsumed;
        private double billAmount;

        public string ConsumerNumber
        {
            get { return this.consumerNumber; }
            set
            {
                //Console.Write("Substring " + value.Substring(0, 2));
                if (value.Substring(0, 2).Equals("EB"))
                {
                    this.consumerNumber = value;
                }
                else
                    //throw new InvalidConsumerNumberException(Msg);
                    throw new FormatException(Msg);
            }
        }
        //public string ConsumerNumber { get; set; }
        public string ConsumerName { get; set; }
        public int UnitsConsumed { get; set; }
        public double BillAmount { get; set; }
    }
    public class BillValidator{
            public String ValidateUnitsConsumed(int UnitsConsumed)
            {
                if(UnitsConsumed < 0){
                    return "Given units is invalid";
                }
                else
                    return "";
            }
        }
}
