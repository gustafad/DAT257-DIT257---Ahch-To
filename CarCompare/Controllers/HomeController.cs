using CarCompare.Models;
using CarCompare.Services;
using CarCompare.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CarCompare.Controllers
{
    public class HomeController : Controller
    {
        static IList<vehicle> vehicleList = new List<vehicle>{
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 },
                new vehicle() { Image = "https://api.auto-data.net/images/f118/Jaguar-E-Pace-facelift-2020_thumb_1.jpg", Model = "I-Pace", Year = 2018 } ,
                new vehicle() { Image = "https://api.auto-data.net/images/f90/Daihatsu-Rocky-A200_thumb.jpg", Model = "E-Pace",  Year = 2021 }


        };

       

        public ActionResult Index()
        {
            ViewBag.CarData = new CarDataVM(CarDataService.CarData());
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}