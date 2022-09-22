using CarCompare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCompare.ViewModels
{
    public class CarDataVM
    {
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

        public void GenerateVehicleList(int brand, int models, int generations, int modifications)
        {
            brandIndex = brand; modelsIndex = models; generationsIndex = generations; modificationIndex = modifications;

            List<Object> Vehicle = new List<Object>();
            Vehicle.Add(name);
            Vehicle.Add(modelYear);
            Vehicle.Add(co2);
            VehicleList.Add(Vehicle);
        }

        public List<Object> GetVehicleList { 
            get {
                return VehicleList;
            } 
        }

        public int GetBrandLength { 
            get 
            {
                return _cd.brand.Length;
            } 
        }
        public int GetModelsLength
        {
            get
            {
                return _cd.brand[brandIndex].models.Length;
            }
        }
        public int GetGenerationsLength
        {
            get
            {
                return _cd.brand[brandIndex].models[modelsIndex].generations.Length;
            }
        }
        public int GetModificationsLength
        {
            get
            {
                return _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].modifications.Length;
            }
        }

        public string name { 
            get
            {
                return _cd.brand[brandIndex].name;
            }
        }
        public string modelYear
        {
            get
            {
                return _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].modelYear.ToString();
            }
        }

        public string co2
        {
            get
            {
                var Items = _cd.brand[brandIndex].models[modelsIndex].generations[0].modifications[generationsIndex].ItemsElementName;
                for (int i = 0; i < Items.Length; i++)
                {
                    if (Items[i].ToString() == "co2")
                    {
                        return _cd.brand[brandIndex].models[modelsIndex].generations[generationsIndex].modifications[modificationIndex].Items[i].ToString();
                    }
                }

                return "This car is all electric, no co2 emission!! :D";                    
            }
        }

    }
}