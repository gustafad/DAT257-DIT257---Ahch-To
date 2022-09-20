using CarCompare.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CarCompare.Services
{
    public class CarDataService
    {
        public static async Task<CarDataDTO> CarData()
        {
            String jsonData = File.ReadAllText(Path.Combine(System.Reflection.Assembly.GetEntryAssembly().Location, @"Content/dataJSON.json"));
            if (jsonData != null)
            {
                CarDataDTO cd = null;
                cd = JsonConvert.DeserializeObject<CarDataDTO>(jsonData);
                return cd;
            }
            else
            {
                return null;
            }
            
        }
    }
}