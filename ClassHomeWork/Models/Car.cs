using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHomeWork.Models
{
    internal class Car : Vehicle
    {
        public Car(string brand, string model, int fuelCapacity, int fuelFor1Km, string color, int year) : base(color, year)
        {
            this.brand = brand;
            this.model = model;
            this.fuelCapacity = fuelCapacity;
            this.fuelFor1Km = fuelFor1Km;
        }

        public string brand;
        public string model;
        public int fuelCapacity;
        public int fuelFor1Km;
        public int currentFuel;

        public void ShowInfo()
        {
            Console.WriteLine($"Current Fuel {currentFuel}");
            Console.WriteLine($"Model {model}");
        }
        public void Drive(int way)
        {
            if (currentFuel < way * fuelFor1Km)
            {
                Console.WriteLine("OLMAZ");
                return;
            }

            currentFuel -= way * fuelFor1Km;
            Console.WriteLine("Yaxsi yol");
        }
    }
}
