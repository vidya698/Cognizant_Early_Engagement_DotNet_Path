/******** FOR REFERENCE ONLY. DO NOT CHANGE *************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp1                
{
    public class Vehicle          
    {
        public String VehicleId{get; set; }
        public String VehicleName{ get; set; }
        public String Brand { get; set; }
        public int ReleaseYear { get; set; }

        public Vehicle(String vehicleId, String vehicleName, String brand,int releaseYear)
        {
            this.VehicleId = vehicleId;
            this.VehicleName = vehicleName;
            this.Brand = brand;
            this.ReleaseYear = releaseYear;
        }
        
    }
}
