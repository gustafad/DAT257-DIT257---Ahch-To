using CarCompare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCompare.ViewModels
{
    // The view model's task is to form a template for all data to be shown so we dont have to repeat it all in the cshtml
    // This class also contains the code for generating the list of cars, for lack of better placement.
    public class CarDataVM
    {
        //Variables. Most notably the _cd is a model from the DTO we created, short for CarData. It contains the actual information 
        private CarDataDTO _cd;
        private List<Object> VehicleList = new List<Object>();
        private int brandIndex;
        private int modelsIndex;
        private int generationsIndex;
        private int modificationIndex;

        public CarDataVM(CarDataDTO model)
        {
            _cd = model;
        }

        //-------------------------------------------------Generation of the VehicleList (might not fit here)-------------------------------------------------

        //May look very bad, but nessesary for the structure that was given in the XML. We work into each brand as far as we can and work outwards when we create the list.
        public void GenerateVehicleList()
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
        public List<Object> GenerateVehicle(int brand, int models, int generations, int modifications)
        {
            brandIndex = brand; modelsIndex = models; generationsIndex = generations; modificationIndex = modifications;

            List<Object> Vehicle = new List<Object>
            {
                name,
                modelYear,
                co2
            };
            return Vehicle;
        }

        //Returns the VehicleList
        public List<Object> GetVehicleList { 
            get {
                return VehicleList;
            } 
        }
        //Returns the BrandLength
        public int GetBrandLength { 
            get 
            {
                return _cd.brand.Length;
            } 
        }
        //Returns the ModelsLength
        public int GetModelsLength
        {
            get
            {
                return _cd.brand[brandIndex].models.Length;
            }
        }
        //Returns the GenerationsLength
        public int GetGenerationsLength
        {
            get
            {
                return _cd.brand[brandIndex].models[modelsIndex].generations.Length;
            }
        }
        //Returns the ModificaitonsLength
        public int GetModificationsLength
        {
            get
            {
                return _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].modifications.Length;
            }
        }

        //-------------------------------------------------Actual view model properties (More to be added)---------------------------------------------

        //Property for getting the name of the current Vehicle
        public string name { 
            get
            {
                return _cd.brand[brandIndex].name + " " + _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].name;
            }
        }
        //Property for getting the model year of the current Vehicle
        public string modelYear
        {
            get
            {
                return _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].modelYear.ToString();
            }
        }
        //Property for getting the co2 emission of the current Vehicle
        public string co2
        {
            get
            {
                //Due to DTO being very weird with XML, we needed to loop through the entire modification array to find the co2. Since the co2 index was inconcistent
                var Items = _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].modifications[modificationIndex].ItemsElementName;
                for (int i = 0; i < Items.Length; i++)
                {
                    if (Items[i].ToString() == "co2")
                    {
                        return _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].modifications[modificationIndex].Items[i].ToString() + " co2 g/km";
                    }
                }

                return "This car is all electric, no co2 emission!! :D";                    
            }
        }

    }
}

