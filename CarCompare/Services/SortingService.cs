using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarCompare.Models;

namespace CarCompare.Services
{
    //Helper class responsible for sorting and filtering all availible vehicles
    public class SortingService
    {
        //Private Arrays
        private readonly List<Vehicle> DefaultList;
        private List<Vehicle> CurrentList;

        //Constructor transforming VehicleList to Internal arrays
        public SortingService(List<Vehicle> VehicleList)
        {
            //Initializes both Lists to be sorted by Co2 emission
            DefaultList = Sort(VehicleList);
            CurrentList = DefaultList;
        }

        //Returns the current array
        public Vehicle[] GetArray()
        {
            return CurrentList.ToArray();
        }

        //Filter current array (!!TODO!! - filter on other/multiple variables) 
        public void Filter()
        {
            List<Vehicle> filteredList = new List<Vehicle>();
            float compVar;

            foreach (Vehicle vehicle in CurrentList)
            {
                compVar = 0;
                if (vehicle.Acceleration != null)
                {
                    compVar = float.Parse(vehicle.Acceleration);
                } 

                if(compVar >= 10)
                {
                    filteredList.Add(vehicle);
                }
            }

            CurrentList = filteredList;
        }

        public void ResetFilter()
        {
            CurrentList = DefaultList;
        }

        //!!To do!! Re-sort List depending on variable
        public List<Vehicle> Sort(List<Vehicle> List)
        {
            return List.OrderBy(vehicle => vehicle.Co2).ToList();
        }

    }
}