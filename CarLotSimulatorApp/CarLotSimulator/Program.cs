using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            Car car1 = new Car();

            car1.Year = 2017;
            car1.Make = "Chrysler";
            car1.Model = "Pacifica";
            car1.EngineNoise = "purr";
            car1.HonkNoise = "beep";
            car1.IsDriveable = true;

            lot.Cars.Add(car1);

            Car car2 = new Car()
            {
                Year = 1968,
                Make = "Chevy",
                Model = "Cruiser",
                EngineNoise = "dead",
                HonkNoise = "what noise?",
                IsDriveable = false
            };

            lot.Cars.Add(car2);

            Car car3 = new Car(2020, "Tesla", "Model S", "**ninja**", "meeeep", true);

            lot.Cars.Add(car3);

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year:{car.Year} Make: {car.Make} Model: {car.Model}");
            }

        }
    }
}
