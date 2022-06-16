using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 1; i <= numberOfCars; i++)
            {
                string input = Console.ReadLine();
                string[] data = input.Split(" ");
                //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
                string model = data[0];
                int engineSpeed = int.Parse(data[1]);
                int enginePower = int.Parse(data[2]);
                int cargoWeight = int.Parse(data[3]);
                string cargoType = data[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                double tire1Pressure = double.Parse(data[5]);
                int tire1Age = int.Parse(data[6]);
                double tire2Pressure = double.Parse(data[7]);
                int tire2Age = int.Parse(data[8]);
                double tire3Pressure = double.Parse(data[9]);
                int tire3Age = int.Parse(data[10]);
                double tire4Pressure = double.Parse(data[11]);
                int tire4Age = int.Parse(data[12]);

                Tires[] tire = new Tires[]
                {
                    new Tires (tire1Age, tire1Pressure),
                    new Tires (tire2Age, tire2Pressure),
                    new Tires (tire3Age, tire3Pressure),
                    new Tires (tire4Age, tire4Pressure)
                };
                Car car = new Car(model, engine, cargo, tire);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(car => car.cargo.Type == "fragile" &&
                car.tires.FirstOrDefault(tire => tire.Pressure < 1) != null)
                .Select(car => car.model).ToList().ForEach(m => Console.WriteLine(m));
            }
            else if (command == "flammable")
            {
                cars.Where(car => car.cargo.Type == "flammable" &&
                car.engine.Power > 250).Select(car => car.model)
                .ToList().ForEach(m => Console.WriteLine(m));
            }
            //List<Car> cars = new List<Car>();

            //for (int i = 1; i <= numberOfCars; i++)
            //{
            //    string data = Console.ReadLine();
            //    string model = data.Split()[0];
            //    double fuelAmount = double.Parse(data.Split()[1]);
            //    double fuelConsumption = double.Parse(data.Split()[2]);

            //    Car car = new Car(model, fuelAmount, fuelConsumption);
            //    cars.Add(car);
            //}

            //string command = Console.ReadLine();
            //while(command != "End")
            //{
            //    string[] cmdArgs = command.Split();
            //    if (cmdArgs[0] == "Drive")
            //    {
            //        string carModel = cmdArgs[1];
            //        double amountKm = double.Parse(cmdArgs[2]);

            //        Car carToDrive = cars.First(car => car.Model == carModel);
            //        carToDrive.Drive(amountKm);
            //    }

            //    command = Console.ReadLine();
            //}
            //foreach (var car in cars)
            //{
            //    Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            //}
        }
    }
}
