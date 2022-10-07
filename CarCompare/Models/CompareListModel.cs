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
        //--Private variables--

        //VehicleList model
        private static VehicleList VehicleList;

        //Lists
        private List<Vehicle> SortedList, FilteredList;

        //Filter variables
        public Boolean showElectric, showHybrid;
        public float accelerationMin, accelerationMax, yearMin, yearMax, rangeMin, rangeMax;
        public List<String> specifiedBrands = new List<string>();
        public List<String> specifiedSeats = new List<string>();



        //--Constructor--
        public CompareListModel()
        {
            //Generates VehicleList model
            VehicleList = new VehicleList();

            //Initializes SortedList and sorts it by Co2 emission
            SortedList = VehicleList.Get();
            Sort("co2", true);

            //Sets the default filter variables
            setDefaultFilter();

            //Initializes FilteredList
            Filter();
        }

        //--PUBLIC METHODS--

        //Get the VehicleArray
        public Vehicle[] GetArray()
        {
            return FilteredList.ToArray();
        }

        public List<Vehicle> GetList()
        {
            return FilteredList.ToList();
        }

        public List<string> GetBrandsList()
        {
            List<string> BrandsList = new List<string>();
            foreach(string brand in FilteredList.Select(brand => brand.Brand).Distinct())
            {
                BrandsList.Add(brand);
            }

            return BrandsList.OrderBy(q => q).ToList();
        }

        //Filter current list after all modified filter variables
        public void Filter()
        {
            List<Vehicle> filteredList = new List<Vehicle>();

            //Loops through all vehicles
            foreach (Vehicle vehicle in SortedList)
            {

                //Filters depending on ShowElectric/showHybrid variable
                if (!showElectric && vehicle.isAllElectric()) { continue; }
                if (!showHybrid && !vehicle.isAllElectric()) { continue; }

                //Filters depending on brand variables if filtering by brands is enabled
                if (brandsSpecified())
                {
                    Boolean isBrand = false;
                    foreach (String brand in specifiedBrands)
                    {
                        if (vehicle.Brand.Equals(brand))
                        {
                            isBrand = true;
                            break;
                        }
                    }
                    if (!isBrand) { continue; }
                }

                //Filters depending on seats variables if filtering by seats is enabled
                if (seatsSpecified())
                {
                    Boolean isSeatNr = false;
                    foreach (String nrOfSeats in specifiedSeats)
                    {
                        if (vehicle.GetModification("places").Contains(nrOfSeats))
                        {
                            isSeatNr = true;
                            break;
                        }
                    }
                    if (!isSeatNr) { continue; }
                }

                //Filters depending on acceleration variables if filtering by acceleration is enabled
                if (accelerationModified())
                {
                    float comp = vehicle.GetComp("acceleration");
                    if (comp == -1) { continue; }
                    if (accelerationMin != -1 && comp < accelerationMin) { continue; }
                    if (accelerationMax != -1 && comp > accelerationMax) { continue; }
                }

                //Filters depending on year variables if filtering by year is enabled
                if (yearModified())
                {
                    float comp = vehicle.GetComp("yearstart");
                    if (comp == -1) { continue; }
                    if (yearMin != -1 && comp < yearMin) { continue; }
                    if (yearMax != -1 && comp > yearMax) { continue; }
                }

                //Filters depending on range variables if filtering by range is enabled
                if (rangeModified())
                {
                    float comp = vehicle.GetComp("allElectricRange");
                    if (comp == -1) { continue; }
                    if (rangeMin != -1 && comp < rangeMin) { continue; }
                    if (rangeMax != -1 && comp > rangeMax) { continue; }
                }

                //Adds vehicles that passed all filter tests to list
                filteredList.Add(vehicle);
            }

            //Sets Filtered list to newly created filteredList
            FilteredList = filteredList;
        }

        //Resets filter variables sets FilteredList to full, sorted List.
        public void ResetFilter()
        {
            setDefaultFilter();
            Filter();
        }


        //--PRIVATE METHODS--



        //Sorts list by Modification variabla. Ascending/Descending set through 'Ascending' boolean parameter.
        public void Sort(String Modification, Boolean Ascending)
        {
            if (Modification == "co2")
            {
                if (Ascending) { this.SortedList = this.SortedList.OrderBy(vehicle => vehicle.GetModification("co2")).ToList(); }
                else { this.SortedList = this.SortedList.OrderByDescending(vehicle => vehicle.GetModification("co2")).ToList(); }
            }
            else
            {
                if (Ascending)
                {
                    this.SortedList = this.SortedList.OrderBy(vehicle => vehicle.GetModification("Modification")).ToList();
                }
                else { this.SortedList = this.SortedList.OrderByDescending(vehicle => vehicle.GetModification("Modification")).ThenBy(vehicle => vehicle.GetModification("co2")).ToList(); }
            }

            Filter();
        }

        //Boolean functions determining if filter variables has been modified/specified
        private Boolean brandsSpecified() { return specifiedBrands.Count != 0; }
        private Boolean seatsSpecified() { return specifiedSeats.Count != 0; }
        private Boolean accelerationModified() { return accelerationMax != -1 || accelerationMin != -1; }
        private Boolean yearModified() { return yearMax != -1 || yearMin != -1; }
        private Boolean rangeModified() { return rangeMax != -1 || rangeMin != -1; }

        //Sets default filter variables
        private void setDefaultFilter()
        {
            showElectric = true;
            showHybrid = true;

            accelerationMin = -1;
            accelerationMax = -1;
            yearMin = -1;
            yearMax = -1;
            rangeMin = -1;
            rangeMax = -1;

            specifiedBrands.Clear();
            specifiedSeats.Clear();

            //--TESTCODE--
            //specifiedBrands.Add("Jeep");
            //specifiedSeats.Add("7");
        }
    }


}