using CarCompare.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace CarCompare.Services
{
    public class CarDataService
    {
        /*      public static CarDataDTO CarData()
              {

              String jsonData = File.ReadAllText("C:/Users/adamt/source/repos/DAT257-DIT257---Ahch-To/CarCompare/dataJSON.json");
                  //String jsonData = "hej";
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

              }*/

        public static CarDataDTO CarData()
        {

            String XMLData = File.ReadAllText("C:/Users/adamt/source/repos/DAT257-DIT257---Ahch-To/CarCompare/data.xml");
            if (XMLData != null)
            {
                CarDataDTO cd = null;

                XmlSerializer serializer = new XmlSerializer(typeof(CarDataDTO));
                using (TextReader reader = new StringReader(XMLData))
                {
                    cd = (CarDataDTO)serializer.Deserialize(reader);
                }

                
                return cd;
            }
            else
            {
                return null;
            }

        }
    }
}