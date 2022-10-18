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

        //returns the modification value of a vehicle given input
        public string GetModification(string mod)
        {
            string output;

            if (mod == "co2" &&
                !this.ModificationDictionary.TryGetValue("co2", out output) &&
                !this.ModificationDictionary.TryGetValue("fuelConsumptionCombined", out output)) { return "0"; }
            if (this.ModificationDictionary.TryGetValue(mod, out output)) { return output; }

            return "Not Found";
        }

        //Returns values that are parsed as floats to be compared
        public float GetComp(String mod)
        {
            float comp = -1;
            string output;

            if (this.ModificationDictionary.TryGetValue(mod, out output))
            {
                if (float.TryParse(output, out comp)) { return comp; }
            }

            return comp;
        }

        //Returns the sorting variable
        public float GetSortVar(String mod)
        {
            String substring = GetModification(mod);
            if( substring.Equals("Not Found") && (mod.Equals("co2") || mod.Equals("acceleration")) ) { return 2000; }
            if (substring.Equals("Not Found") && mod.Equals("allElectricRange")) { return 0; }

            substring = substring.Split('-', '.')[0];
            float result = -1;
            if (float.TryParse(substring, out result)) { return result; }
            return result;

        }
        //Returns whether or not the car is all electric, this is a special case since not all have c02 data
        public Boolean isAllElectric()
        {
            return this.GetModification("co2") == "0" && this.GetModification("fuelConsumptionCombined") == "Not Found";
        }

        //Returns the url that (learn more) button should redirect the user to
        public string GetSearchURL()
        {
            return ("https://www.google.com/search?q=" + this.Brand + "+" + this.Generation + "+" + this.GetModification("yearstart"));
        }
    }
}