using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCompare.Models
{
    //Vehicle model class
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
            return ("https://www.google.com/search?q=" + this.Brand + "+" + this.Generation + "+" + this.GetModification("yearstart"));
        }
    }
}