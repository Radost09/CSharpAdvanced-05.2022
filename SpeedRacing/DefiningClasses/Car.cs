using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo, Tires[] tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;

            //this.FuelAmount = fuelAmount;
            //this.FuelConsumptionPerKilometer = fuelConsumptionPerKm;
            //this.TravelledDistance = 0;
        }

        //private double fuelAmount;
        //private double fuelConsumptionPerKilometer;
        //private double travelledDistance;

        public string model { get; set; }
        public Engine engine { get; set; }
        public Cargo cargo { get; set; }
        public Tires[] tires { get; set; }
 

        //public double FuelAmount { get; set; }

        //public double FuelConsumptionPerKilometer { get; set; }

        //public double TravelledDistance { get; set; }

        //public void Drive(double amountOfKm)
        //{
        //    double neededFuel = amountOfKm * FuelConsumptionPerKilometer;

        //    if(FuelAmount >= neededFuel)
        //    {
        //        FuelAmount -= neededFuel;
        //        TravelledDistance += amountOfKm;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Insufficient fuel for the drive");
        //    }
        //}
    }
}
