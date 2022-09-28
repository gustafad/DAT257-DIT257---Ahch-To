using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarCompare.Models;
using CarCompare.Services;

namespace CarCompare.Models
{

    public class Vehicle
    {
        public string Brand;
        public string Model;
        public string Generation;
        public string MaxSpeed;
        public string Acceleration;
        public string Acceleration60;
        public string Yearstart;
        public string Coupe;
        public string Places;
        public string PlacesMin;
        public string Drive;
        public string StandardFCc;
        public string FuelConsumptionCombined;
        public string FuelConsumptionCombinedMin;
        public string FuelConsumptionCombinedMax;
        public string EmissionStandard;
        public string StandardCO2;
        public string Co2;
        public string Co2Min;
        public string Co2Max;

        public Vehicle(string brand, string model, string generation, string maxSpeed, string acceleration, string acceleration60, string yearstart, string coupe, string places, string placesMin, string drive, string standardFCc, string fuelConsumptionCombined, string fuelConsumptionCombinedMin, string fuelConsumptionCombinedMax, string emissionStandard, string standardCO2, string co2, string co2Min, string co2Max)
        {
            Brand = brand;
            Model = model;
            Generation = generation;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            Acceleration60 = acceleration60;
            Yearstart = yearstart;
            Coupe = coupe;
            Places = places;
            PlacesMin = placesMin;
            Drive = drive;
            StandardFCc = standardFCc;
            FuelConsumptionCombined = fuelConsumptionCombined;
            FuelConsumptionCombinedMin = fuelConsumptionCombinedMin;
            FuelConsumptionCombinedMax = fuelConsumptionCombinedMax;
            EmissionStandard = emissionStandard;
            StandardCO2 = standardCO2;
            Co2 = co2;
            Co2Min = co2Min;
            Co2Max = co2Max;
        }
    }

    public class VehicleListModel
    {
        //Private variables
        private CarDataDTO _cd;
        private List<Vehicle> VehicleList = new List<Vehicle>();
        private SortingService SortingService;
        private int brandIndex;
        private int modelsIndex;
        private int generationsIndex;
        private int modificationIndex;

        //Constructor
        public VehicleListModel(CarDataDTO model)
        {
            _cd = model;
            this.GenerateVehicleList();

            //Creates a private SortingService for the VehicleList
            SortingService = new SortingService(VehicleList);
        }


        //--PRIVATE HELPER METHODS--

        //Generates the list.
        //May look very bad, but nessesary for the structure that was given in the XML. We work into each brand as far as we can and work outwards when we create the list.
        private void GenerateVehicleList()
        {
            for (int b = 0; b < GetBrandLength; b++)
            {
                for (int m = 0; m < GetModelsLength; m++)
                {
                    for (int g = 0; g < GetGenerationsLength; g++)
                    {
                        for (int mod = 0; mod < GetModificationsLength; mod++)
                        {
                            VehicleList.Add(GenerateVehicle(b, m, g, mod));
                        }
                    }
                }
            }
        }

        //Generates a single vehicle given the indexes that is required to get a single vehicle. 
        private Vehicle GenerateVehicle(int brand, int models, int generations, int modifications)
        {
            brandIndex = brand; 
            modelsIndex = models; 
            generationsIndex = generations; 
            modificationIndex = modifications;

            Vehicle Vehicle = vehicle;

            return Vehicle;
        }

           //Returns the BrandLength
        private int GetBrandLength
        {
            get
            {
                return _cd.brand.Length;
            }
        }

        //Returns the ModelsLength
        private int GetModelsLength
        {
            get
            {
                return _cd.brand[brandIndex].models.Length;
            }
        }

        //Returns the GenerationsLength
        private int GetGenerationsLength
        {
            get
            {
                return _cd.brand[brandIndex].models[modelsIndex].generations.Length;
            }
        }

        //Returns the ModificaitonsLength
        private int GetModificationsLength
        {
            get
            {
                return _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].modifications.Length;
            }
        }

        //Creates new Vehicle
        private Vehicle vehicle
        {
            get
            {

                Vehicle tmpVehicle = new Vehicle
                (
                    Modinfo("brand"),
                    Modinfo("model"),
                    Modinfo("generation"),
                    Modinfo("maxSpeed"),
                    Modinfo("acceleration"),
                    Modinfo("acceleration60"),
                    Modinfo("yearstart"),
                    Modinfo("coupe"),
                    Modinfo("places"),
                    Modinfo("placesMin"),
                    Modinfo("drive"),
                    Modinfo("standardFCc"),
                    Modinfo("fuelConsumptionCombined"),
                    Modinfo("fuelConsumptionCombinedMin"),
                    Modinfo("fuelConsumptionCombinedMax"),
                    Modinfo("emissionStandard"),
                    Modinfo("standardCO2"),
                    Modinfo("co2"),
                    Modinfo("co2Min"),
                    Modinfo("co2Max")
                );

                return tmpVehicle;


            }

        }

        //Extracts Modinfo and translates to Strings
        private string Modinfo(string ModVariable)
        {
            var Items = _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].modifications[modificationIndex].ItemsElementName;
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i].ToString() == ModVariable)
                {
                    var test = _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].modifications[modificationIndex].Items[i].ToString();
                    return test;
                }
            }
            return null;
        }

        //--Public Vehicle List methods--

        //Get the VehicleArray
        public Vehicle[] GetArray()
        {
            return this.SortingService.GetArray();
        }

        //Filter the VehicleArray
        public void Filter()
        {
            this.SortingService.Filter();
        }

        public void ResetFilter()
        {
            this.SortingService.ResetFilter();
        }

    }


}