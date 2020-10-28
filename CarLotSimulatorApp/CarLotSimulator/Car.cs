using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivebable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDrivebable;
        }

        public string MakeEngineNoise()
        {
            return EngineNoise;
        }
        public string MakeHonkNoise()
        {
            return HonkNoise;
        }
    }
}
