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
        public string id
        {
            get
            {
                return "Id is: " + _cd.brand[0].id;
            }
        }

    }
}