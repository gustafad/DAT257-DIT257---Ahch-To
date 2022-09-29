using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarCompare.Models;

namespace CarCompare.Services
{
    public class SortingService
    {

        private Vehicle[] VehicleArray;
        public SortingService(List<Vehicle> VehicleList)
        {
            VehicleArray = VehicleList.ToArray();
        }

        public Vehicle[] GetSortedVehicles
        {
            get
            {
                return VehicleArray.OrderBy(vehicle => { string value = vehicle.GetModification("co2"); if (value == "Not Found") { return "0"; } return value; }).ToArray();
            }
        }

    }
}