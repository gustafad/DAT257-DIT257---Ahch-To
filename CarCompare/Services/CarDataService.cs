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
    //The service class has the job of collecting the data and handling it accordingly
    public class CarDataService
    {
        //Finds the local path of the XML file using MapPath. 
        public static CarDataDTO CarData()
        {
            string LocalPath = HttpContext.Current.Server.MapPath(@"~/data.xml");
            String XMLData = File.ReadAllText(LocalPath);
            if (XMLData != null)
            {
                CarDataDTO cd = null;

                //Changes the structure of the data given from the XML file to classes.
                XmlSerializer serializer = new XmlSerializer(typeof(CarDataDTO));
                using (TextReader reader = new StringReader(XMLData))
                {
                    cd = (CarDataDTO)serializer.Deserialize(reader);
                }

                return cd;
            }
            //if for some reason the data is null, eg. not available then we return null to be handled as a Error in the controller.
            else
            {
                return null;
            }

        }
    }
}