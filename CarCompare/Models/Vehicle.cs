using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCompare.Models
{
    public class Vehicle
    {
        public string Brand;
        public string Model;
        public string Generation;
        public string MaxSpeed;
        public string Acceleration;
        public string Acceleration60;
        public string Yearstart;
        public string Coupe;
        public string Places;
        public string PlacesMin;
        public string Drive;
        public string StandardFCc;
        public string FuelConsumptionCombined;
        public string FuelConsumptionCombinedMin;
        public string FuelConsumptionCombinedMax;
        public string EmissionStandard;
        public string StandardCO2;
        public string Co2;
        public string Co2Min;
        public string Co2Max;

        public Vehicle(string brand, string model, string generation, string maxSpeed, string acceleration, string acceleration60, string yearstart, string coupe, string places, string placesMin, string drive, string standardFCc, string fuelConsumptionCombined, string fuelConsumptionCombinedMin, string fuelConsumptionCombinedMax, string emissionStandard, string standardCO2, string co2, string co2Min, string co2Max)
        {
            Brand = brand;
            Model = model;
            Generation = generation;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            Acceleration60 = acceleration60;
            Yearstart = yearstart;
            Coupe = coupe;
            Places = places;
            PlacesMin = placesMin;
            Drive = drive;
            StandardFCc = standardFCc;
            FuelConsumptionCombined = fuelConsumptionCombined;
            FuelConsumptionCombinedMin = fuelConsumptionCombinedMin;
            FuelConsumptionCombinedMax = fuelConsumptionCombinedMax;
            EmissionStandard = emissionStandard;
            StandardCO2 = standardCO2;
            Co2 = co2;
            Co2Min = co2Min;
            Co2Max = co2Max;
        }
    }
}