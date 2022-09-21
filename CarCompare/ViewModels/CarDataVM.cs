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

        public CarDataVM(CarDataDTO model)
        {
            _cd = model;
        }

        public string name { 
            get
            {
                return "Model is: " + _cd.brand[0].name;
            }
        }
        public string modelYear
        {
            get
            {
                return "Id is: " + _cd.brand[0].models[0].generations[0].modelYear;
            }
        }

        public string co2
        {
            get
            {
                //if (_cd.brand[0].models[0].generations[0].modifications[0].Items.Contains("co2"))
                    return "Id is: " + _cd.brand[0].models[0].generations[0].modifications[0];
            }
        }

    }
}