using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarCompare.Services;

namespace CarCompare.Models
{
    public class VehicleList
    {
        //Private variables
        private static CarDataDTO _cd = CarDataService.CarData();
        private static List<Vehicle> List;
        private int brandIndex;
        private int modelsIndex;
        private int generationsIndex;
        private int modificationIndex;

        //Constructs the list.
        //May look very bad, but nessesary for the structure that was given in the XML. We work into each brand as far as we can and work outwards when we create the list.
        public VehicleList()
        {
            List = new List<Vehicle>();

            for (int b = 0; b < GetBrandLength; b++)
            {
                for (int m = 0; m < GetModelsLength; m++)
                {
                    for (int g = 0; g < GetGenerationsLength; g++)
                    {
                        for (int mod = 0; mod < GetModificationsLength; mod++)
                        {
                            List.Add(GenerateVehicle(b, m, g, mod));
                        }
                    }
                }
            }
        }

        //--PUBLIC METHODS--
        public List<Vehicle> Get()
        {
            return List;
        }

        //--PRIVATE HELPER METHODS--

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
    }
}