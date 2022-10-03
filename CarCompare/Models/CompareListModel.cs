using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarCompare.Models;

namespace CarCompare.Models
{

    //Model class containing representation of and all functions needed for getting/sorting/filtering the list.
    //Vehicle model and the VehicleList model are in separate classes.
    public class CompareListModel
    {
        //Private variables
        private static VehicleList VehicleList;
        private List<Vehicle> CurrentList;

        //Constructor
        public CompareListModel()
        {
            //Generates VehicleList
            VehicleList = new VehicleList();
            //Creates CurrentList and sorts it by Co2 emission
            CurrentList = Sort(VehicleList.Get());
        }

        //--PUBLIC METHODS--

        //Get the VehicleArray
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
                if (!vehicle.GetModification("acceleration").Equals("Not Found"))
                {
                    compVar = float.Parse(vehicle.GetModification("acceleration"));
                }

                if (compVar >= 10)
                {
                    filteredList.Add(vehicle);
                }
            }

            CurrentList = filteredList;
        }

        //Resets
        public void ResetFilter()
        {
            CurrentList = Sort(VehicleList.Get());
        }


        //--PRIVATE METHODS--

        //Sorts list by Co2 emission (!!TODO!! - Re-sort List depending on variable)
        public List<Vehicle> Sort(List<Vehicle> List)
        {
            return List.OrderBy(
                vehicle => { 
                string value = vehicle.GetModification("co2"); 
                if (value == "Not Found" && vehicle.GetModification("fuelConsumptionCombined") == "Not Found") {
                    return "0"; } return value; 
                }
            ).ToList();
        }
    }


}