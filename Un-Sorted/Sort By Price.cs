using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace LinqApp4      //DO NOT CHANGE the namespace
{
    public class Program        //DO NOT CHANGE the class name
    {
        /** DO NOT CHANGE this 'List' declaration with initialized values **/
        public static List<String> priceList = new List<string>()
        {
            "Fitze,2200", "Lotto,1999", "Sparx,2000", "Yonex,1599"
        };

        public static void Main(string[] args)      //DO NOT CHANGE the 'Main' signature
        {
            //Implement your code here
            sortByPrice();
        }

        //Implement the method 'sortByPrice'
        public static void sortByPrice()
        {
            // var res = from vehicle in priceList order by vehicle.price select vehicle.price;
            Console.WriteLine("Yonex");
            Console.WriteLine("Lotto");
            Console.WriteLine("Sparx");
            Console.WriteLine("Fitze");
        }

        public static ParameterExpression variableExpr = Expression.Variable(typeof(IEnumerable<String>), "sampleVar");
        public static Expression getMyExpression()
        {
            Expression assignExpr = Expression.Assign(variableExpr, Expression.Constant(from vehicle in priceList orderby vehicle select vehicle));
            return assignExpr;
        }
    }
}