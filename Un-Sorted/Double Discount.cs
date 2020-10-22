using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_Enum
{
    enum CardType
    {
        Gold,
        Silver,
        Bronze,
        Null
    }; 
    class Program
    {     
        

        static void Main()
        {
            Console.WriteLine("Enter Customer's Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the amount purchased");
            double purchasedAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the type of Customer's Membership Card");
            string cardString = Console.ReadLine();
            Purchase customer = new Purchase()
            {
                CustomerName = name,
                PurchaseAmount = purchasedAmount
            };
            if (cardString == CardType.Gold.ToString())
            {
                customer.MemberCardType = CardType.Gold;
            }
            else if (cardString == CardType.Silver.ToString())
            {
                customer.MemberCardType = CardType.Silver;
            }
            else if (cardString == CardType.Bronze.ToString())
            {
                customer.MemberCardType = CardType.Bronze;
            }
            else
            {
                customer.MemberCardType = CardType.Null;
            }
            customer.PayableAmount=customer.CalculateNetPayableAmount(customer.MemberCardType, customer.CalculateDiscount());

            customer.DisplayDetails();
        }
        struct Purchase
        {
            public string CustomerName { get; set; }
            public double PurchaseAmount { get; set; }
            public CardType MemberCardType { get; set; }
            public double PayableAmount { get; set; }
            public double  CalculateDiscount()
            {
                if(this.PurchaseAmount>=10000)
                {
                   return this.PurchaseAmount/2;
                }
               else if (this.PurchaseAmount >= 5000)
                {
                    return this.PurchaseAmount-this.PurchaseAmount/10;
                }
                else if (this.PurchaseAmount >= 3000)
                {
                    return this.PurchaseAmount-this.PurchaseAmount/20;
                }   
                else
                {
                    return this.PurchaseAmount;
                }
                return deducedAmount;
            }
            public double CalculateNetPayableAmount(CardType x, double y)
            {
                if (x == CardType.Gold)
                {
                    return (y - 1000);
                }
                if (x == CardType.Silver)
                {
                    return (y - 500);
                }
                if (x == CardType.Bronze)
                {
                    return (y - 200);
                }
                else
                {
                    return (y);
                }
            }
            public void DisplayDetails()
            {
                Console.WriteLine("Customer Name:{0,-10} Customer Purchased amount:{1,-10} Customer CardType:{2,-10} Customer's Payable Amount:{3}",this.CustomerName,this.PurchaseAmount,this.MemberCardType,this.PayableAmount);
                Console.ReadKey();

            }
		}			
    }
}
