using System;
using System.Collections.Generic;
using System.IO;
using static ConsoleApp1.Program.Purchase;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var purchase = new Purchase();
            
            Console.WriteLine("Enter customer name");
            var customerName = Console.ReadLine();
            if (string.IsNullOrEmpty(customerName))
            {
                throw new Exception("Customer name is null or empty");
            }
            purchase.CustomerName = customerName;

            Console.WriteLine("Enter purchase amount");
            var purchaseAmount = Console.ReadLine();
            if (string.IsNullOrEmpty(purchaseAmount))
            {
                throw new Exception("Purchase amount is null or empty");
            }
            purchase.PurchaseAmount = Convert.ToDouble(purchaseAmount);

            Console.WriteLine("Enter card type");
            var cardType = Console.ReadLine();
            if (!string.IsNullOrEmpty(cardType))
            {
                purchase.MemberCardType = Enum.Parse<CardType>(cardType, true);
            }

            var discountedPurchaseAmount = CalculateDiscount(purchase.PurchaseAmount);

            purchase.PayableAmount = CalculateNetPayableAmount(purchase.MemberCardType, discountedPurchaseAmount);

            DisplayDetails(purchase);
        }

        public static double CalculateNetPayableAmount(CardType? cardType, double discountedPurchaseAmount)
        {
            int membershipDiscound = 0;

            switch (cardType)
            {
                case CardType.Gold:
                    membershipDiscound = 1000;
                    break;
                case CardType.Silver:
                    membershipDiscound = 500;
                    break;
                case CardType.Bronze:
                    membershipDiscound = 200;
                    break;
                default:
                    break;
            }

            return discountedPurchaseAmount - membershipDiscound;
        }

        public static double CalculateDiscount(double purchaseAmount)
        {
            var discoundPercentage = 0;

            if (purchaseAmount >= 10000)
            {
                discoundPercentage = 50;
            }
            else if (purchaseAmount >= 5000 && purchaseAmount < 10000)
            {
                discoundPercentage = 10;
            }
            else if (purchaseAmount >= 3000 && purchaseAmount < 5000)
            {
                discoundPercentage = 5;
            }

            return purchaseAmount - (purchaseAmount * discoundPercentage / 100);
        }

        public static void DisplayDetails(Purchase purchase)
        {
            Console.WriteLine($"Customer name: {purchase.CustomerName}");
            Console.WriteLine($"Purchase amount: {purchase.PurchaseAmount}");
            Console.WriteLine($"Card type: {purchase.MemberCardType}");
            Console.WriteLine($"Net payable amount: {purchase.PayableAmount}");
        }

        public struct Purchase
        {
            public string CustomerName { get; set; }
            public double PurchaseAmount { get; set; }
            public CardType MemberCardType { get; set; }
            public double PayableAmount { get; set; }

            
        }
        
        public enum CardType
        {
            Gold,
            Silver,
            Bronze,
            Null
        }
    }
}