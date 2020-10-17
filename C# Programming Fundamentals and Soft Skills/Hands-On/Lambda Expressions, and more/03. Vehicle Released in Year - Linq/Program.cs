using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace LinqApp1                //DO NOT CHANGE the namespace name
{
    
    public class Program         //DO NOT CHANGE the class name
    {
        /** DO NOT CHANGE this 'List' declaration with initialized values  **/
        public static List<Vehicle> vehicleList = new List<Vehicle>()
                                {
                                    new Vehicle("HO345","CRV","Honda",2015),
                                    new Vehicle("HY562","Creta","Hyundai",2017),
                                    new Vehicle("RE198","Duster","Reanult",2014),
                                    new Vehicle("MA623","Spacio","Suzuki",2014),
                                    new Vehicle("TR498","Nexon","Tata",2015),
                                    new Vehicle("TR981","Zest","Tata",2016),
                                    new Vehicle("HO245","WRV","Honda",2018)

                                };

        static void Main(string[] args)   //DO NOT Change this 'Main' signature
        {
            //Implement your code here
            Console.WriteLine("Enter From Year:");
            int fromYear=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter To Year:");
            int toYear=Convert.ToInt32(Console.ReadLine());
            getVehicleName(fromYear,toYear);
        }

        //Implement the method 'getVehicleName' here
        public static void getVehicleName(int fromYear,int toYear){
            IEnumerable<Vehicle> vehicles=from vehicle in vehicleList where vehicle.ReleaseYear>=fromYear && vehicle.ReleaseYear<=toYear select vehicle ;
            foreach(Vehicle vehicle in vehicles)
            Console.WriteLine(vehicle.VehicleName);
        } 
        

         /** DO NOT CHANGE this ParameterExpression **/  
        public static ParameterExpression variableExpr = Expression.Variable(typeof(IEnumerable<Vehicle>), "sampleVar");
        
        public static Expression getMyExpression(int fromYear, int toYear)
        {  
            Expression assignExpr = Expression.Assign(variableExpr, Expression.Constant(from vehicle in vehicleList where vehicle.ReleaseYear>=fromYear && vehicle.ReleaseYear<=toYear select vehicle));
            return assignExpr;
        }

    }
}
