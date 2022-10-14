﻿using CarCompare.Models;
using CarCompare.Services;
using CarCompare.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CarCompare.Controllers
{
    public class HomeController : Controller
    {
        //Static CompareListModel creation
        static CompareListModel CLM = new CompareListModel();


        //Index page (Home page) 
        public ActionResult Index()
        {
            return View("Index", CLM);
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

        [HttpPost]
        public ActionResult FilterField(FormCollection variables)
        {
            if(!string.IsNullOrEmpty(variables["allElectric"])) { CLM.showElectric = true; }
            else { CLM.showElectric = false; }

            if (!string.IsNullOrEmpty(variables["hybrid"])) { CLM.showHybrid = true; }
            else { CLM.showHybrid = false; }

            foreach(string brand in CLM.GetBrandsList())
            {
                if (!string.IsNullOrEmpty(variables[brand])) 
                { 
                    CLM.specifiedBrands.Add(brand); 
                }
            }

            for (int i = 1; i <= 9; i++)
            {
                string st =  i.ToString();
                if (!string.IsNullOrEmpty(variables["seats " + st]))
                {
                    CLM.specifiedSeats.Add(st);
                }
            }

            if (!string.IsNullOrEmpty(variables["rangeMin"])) { CLM.rangeMin = int.Parse(variables["rangeMin"]); }

            if (!string.IsNullOrEmpty(variables["rangeMax"])) { CLM.rangeMax = int.Parse(variables["rangeMax"]); }

            if (!string.IsNullOrEmpty(variables["yearMin"])) { CLM.yearMin = int.Parse(variables["yearMin"]); }

            if (!string.IsNullOrEmpty(variables["yearMax"])) { CLM.yearMax = int.Parse(variables["yearMax"]); }

            if (!string.IsNullOrEmpty(variables["acceleration"])) { CLM.accelerationMax = int.Parse(variables["acceleration"]); }


            if (!string.IsNullOrEmpty(variables["numberOfShownCars"])) { CLM.numberOfShownCars = int.Parse(variables["numberOfShownCars"]); }
            else { CLM.numberOfShownCars = (CLM.GetArray().Length < 25) ? CLM.GetArray().Length : 25; }

            

            if (!string.IsNullOrEmpty(variables["button"]))
            {
                if (variables["button"].Equals("filter")) { CLM.Filter(); }
                if (variables["button"].Equals("reset")) { CLM.ResetFilter(); }
            }

            return View("Index", CLM);
        }

        [HttpPost]
        public ActionResult SortingField(FormCollection variables)
        {
            if (!string.IsNullOrEmpty(variables["sorting"]))
            {
                String selectedSorting = variables["sorting"];

                if (selectedSorting.Equals(CLM.sortedBy)) { CLM.ascending = !CLM.ascending; }
                else if(selectedSorting.Equals("yearstart") || selectedSorting.Equals("allElectricRange")) { CLM.ascending = false; }
                else { CLM.ascending = true; }
                CLM.sortedBy = selectedSorting;
                CLM.Sort();
            }
            return View("Index", CLM);
        }

    }
}