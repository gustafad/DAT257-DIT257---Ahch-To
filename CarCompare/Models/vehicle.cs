using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompare.Models
{
    public class vehicle
    {
        public string Image { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public int Carbon_Emissions { get; set; }
    }
}
