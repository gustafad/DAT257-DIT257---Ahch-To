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
        public string ModelYear;
        public string Image;
        public Dictionary<string, string> ModificationDictionary;

        public Vehicle(string brand, string model, string generation, string modelYear, Dictionary<string, string> modificationDictionary, string image)
        {
            Brand = brand;
            Model = model;
            Generation = generation;
            ModelYear = modelYear;
            Image = image;
            ModificationDictionary = modificationDictionary;
        }
        public string GetModification(string mod)
        {
            string output = "";
            if (this.ModificationDictionary.TryGetValue(mod, out output))
            {
                return output;
            }
            return "Not Found";
        }
        public string GetSearchURL()
        {
            return ("https://www.google.com/search?q=" + this.Brand +"+"+ this.Generation + "+" + this.ModelYear);
        }
    }

    public class VehicleListModel
    {
        private CarDataDTO _cd;
        private List<Vehicle> VehicleList = new List<Vehicle>();
        private int brandIndex;
        private int modelsIndex;
        private int generationsIndex;
        private int modificationIndex;

        public VehicleListModel(CarDataDTO model)
        {
            _cd = model;
        }

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
        public Vehicle GenerateVehicle(int brand, int models, int generations, int modifications)
        {
            brandIndex = brand; modelsIndex = models; generationsIndex = generations; modificationIndex = modifications;

            Vehicle Vehicle = vehicle;

            return Vehicle;
        }

        //Returns the VehicleList
        public List<Vehicle> GetVehicleList
        {
            get
            {
                return VehicleList;
            }
        }
        //Returns the BrandLength
        public int GetBrandLength
        {
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

        //----------------------------------------------------------------------------------------

        public Vehicle vehicle
        {
            get
            {

                Vehicle tmpVehicle = new Vehicle
                (
                    _cd.brand[brandIndex].name,
                    _cd.brand[brandIndex].models[modelsIndex].name,
                    _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].name,
                    _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].modelYear.ToString(),
                    GetModDictionary(),
                    GetImage()
                ) ;

                return tmpVehicle;


            }

        }

        public Dictionary<string, string> GetModDictionary()
        {
            var Items = _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].modifications[modificationIndex].ItemsElementName;
            Dictionary<string, string> modifications = new Dictionary<string, string>();
            for (int i = 0; i < Items.Length; i++)
            {
                modifications.Add(Items[i].ToString(), _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].modifications[modificationIndex].Items[i].ToString());
            }
            return modifications;
        }

        public string GetImage()
        {
            //Checks to see if any images exist for the model generation and if not returns noCarImage
            if (_cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].images.Count() != 0)
            {
                return _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].images[0].big;
            }
            else
            {
                return "/Content/images/no_image.png";
            }
        }

        public Vehicle[] GetSortedVehicles
        {
            get
            {
                return new SortingService(VehicleList).GetSortedVehicles;
            }
        }

    }


}