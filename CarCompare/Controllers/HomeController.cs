using CarCompare.Models;
using CarCompare.Services;
//using CarCompare.ViewModels;
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
        //Index page (home page) has the actual data
        public ActionResult Index()
        {
            //move this to static outside so it does not load everytime index is loaded
            ViewBag.CarData = new VehicleListModel(CarDataService.CarData());
            if (ViewBag.CarData == null)
            {
                //Return the error page instad here
                return View("About");
            }
            return View();
        }

        public ActionResult About()
        {
            
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}