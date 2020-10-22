using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuaranceProject
{
    class Insurance
    {
        private string insuranceNo;
        private string insuranceName;
        private double amountCovered;

        public string InsuranceNo { get; set; }
        public string InsuranceName { get; set; }
        public double AmountCovered { get; set; }
    }

    class LifeInsurance : Insurance
    {
        private int policyTerm;
        private float benefitPercent;
        public int PolicyTerm { get; set; }
        public float BenefitPercent { get; set; }
        public double calculatePremium()
        {
            return (AmountCovered - ((AmountCovered * ((double) BenefitPercent)) / 100.0)) / ((double) PolicyTerm); 
        }
    }

    class MotorInsurance : Insurance
    {
        private double idv;
        private float depPercent;
        public double Idv { set; get; }
        public float DepPercent { get; set; }

        public double calculatePremium()
        {
            Idv = AmountCovered - ((AmountCovered * ((double) DepPercent)) / 100.0);
            return 0.03 * Idv;         
        }
    }

    class Program
    {
        public double addPolicy(Insurance ins, int opt)
        {
            if (opt == 1)
            {
                LifeInsurance l = (LifeInsurance)ins;
                return l.calculatePremium();
            }
            else
            {
                MotorInsurance m = (MotorInsurance)ins;
                return m.calculatePremium();
            }
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            //  Insurance i = new Insurance();
            LifeInsurance li = new LifeInsurance();
            MotorInsurance mi = new MotorInsurance();
            Console.Write("Insurance Number : ");
            li.InsuranceNo = mi.InsuranceNo = Console.ReadLine();
            Console.Write("Insurance Name : ");
            li.InsuranceName = mi.InsuranceName = Console.ReadLine();
            Console.Write("Amount Covered : ");
            li.AmountCovered = mi.AmountCovered = double.Parse(Console.ReadLine());
            Console.WriteLine("Select");
            Console.WriteLine("1.Life Insurance");
            Console.WriteLine("2.Motor Insurance");
            int option = int.Parse(Console.ReadLine());
          
            if (option == 1)
            {
                Console.Write("Policy Term : ");
                li.PolicyTerm = int.Parse(Console.ReadLine());
                Console.Write("Benefit Percent : ");
                li.BenefitPercent = int.Parse(Console.ReadLine());
                Console.WriteLine("Calculated Premium: " + p.addPolicy(li, option));
                Console.ReadLine();
            }
            if (option == 2)
            {
                Console.WriteLine("Dep Percent");
                mi.DepPercent = float.Parse(Console.ReadLine());
                Console.WriteLine("Calculated Premium: " + p.addPolicy(mi, option));
                Console.ReadLine();
            }
        }
    }
}