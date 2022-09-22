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
        public static CarDataDTO CarData()
        {
            string LocalPath = HttpContext.Current.Server.MapPath(@"~/data.xml");
            String XMLData = File.ReadAllText(LocalPath);
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