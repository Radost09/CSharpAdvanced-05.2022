using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //string make = Console.ReadLine();
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine());
            //double fuelConsumption = double.Parse(Console.ReadLine());

            //Car firstCar = new Car();
            //Car secondCar = new Car(make, model, year);
            //Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            //Console.WriteLine(firstCar.WhoAmI());
            //Console.WriteLine();
            //Console.WriteLine(secondCar.WhoAmI());
            //Console.WriteLine();
            //Console.WriteLine(thirdCar.WhoAmI());
            //Console.WriteLine();

            //Tire[] lamboTires = new Tire[]
            //{
            //    new Tire(2018, 2.4),
            //    new Tire(2018, 2.5),
            //    new Tire(2018, 2.4),
            //    new Tire(2018, 2.5),
            //};

            //Engine lamboEngine = new Engine(560, 4300);

            //Car lamboCar = new Car("Lamborghini", "Ursus", 2015, 80, 0.12, lamboEngine, lamboTires);
            //lamboCar.Drive(50);
            //Console.WriteLine(lamboCar.WhoAmI());
            //Console.WriteLine();

            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            HashSet<List<int>> pess = new HashSet<List<int>>();

            string command = Console.ReadLine();
            while(command != "No more tires")
            {
                var tiresInfo = command.Split();
                var currentTires = new Tire[4];
                int count = 0;

                for (int i = 0; i < tiresInfo.Length; i += 2)
                {
                    int year = int.Parse(tiresInfo[i]);
                    double pressure = double.Parse(tiresInfo[i + 1]);

                    var tire = new Tire(year, pressure);
                    currentTires[count] = tire;
                    count++;
                }
                tires.Add(currentTires);

                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while(command != "Engines done")
            {
                var engineInfo = command.Split();
                var horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);

                var engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);

                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while(command != "Show special")
            {
                var carInfo = command.Split();

                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                var engine = engines[engineIndex];
                var tirePack = tires[tiresIndex];

                var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tirePack);
                cars.Add(car);

                command = Console.ReadLine();
            }

            var specialCars = cars.Where(x => x.Year >= 2017 &&
            x.Engine.HorsePower > 330 &&
            x.Tires.Sum(p => p.Pressure) >= 9 &&
            x.Tires.Sum(p => p.Pressure) <= 10).ToList();

            foreach (var specialCar in specialCars)
            {
                specialCar.Drive(20);
            }
            foreach (var specialCar in specialCars)
            {
                Console.WriteLine($"Make: {specialCar.Make}\n" +
                                  $"Model: {specialCar.Model}\n" +
                                  $"Year: {specialCar.Year}\n" +
                                  $"HorsePowers: {specialCar.Engine.HorsePower}\n" +
                                  $"FuelQuantity: {specialCar.FuelQuantity}");
            }

            //Car car = new Car();

            //car.Make = "VW";
            //car.Model = "MK3";
            //car.Year = 1992;
            //car.FuelQuantity = 200;
            //car.FuelConsumption = 200;
            //car.Drive(2000);
            //Console.WriteLine(car.WhoAmI());

            //Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
