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
        //Static VehicleList & SortingService creation
        static VehicleListModel VLM = new VehicleListModel(CarDataService.CarData());

        //Index page (Home page) 
        public ActionResult Index()
        {
            ViewBag.VehicleListModel = VLM;
            if (ViewBag.VehicleListModel == null)
            {
                //Return the error page instad here
                return View("About");
            }
            return View("Index", VLM);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Error404()
        {
            return View();
        }
        public ActionResult Error500()
        {
            return View();
        }

        public ActionResult HandleFilterButton(String button)
        {
            int action = Int32.Parse(button);
            switch(action)
            {
                case 1:
                    VLM.Filter();
                    break;
                case 2:
                    VLM.ResetFilter();
                    break;
            }
            return View("Index", VLM);
        }

    }
}