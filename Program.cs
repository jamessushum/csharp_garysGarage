using System;

namespace gary_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fx = new Zero();
            Cessna oneSevenTwo = new Cessna();
            Tesla modelS = new Tesla();
            Ram fifteenHundred = new Ram();

            fx.Drive();
            oneSevenTwo.Drive();
            modelS.Drive();
            fifteenHundred.Drive();
        }
    }

    public class Zero : Vehicle
    {
        public double BatteryKwh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Battery low...please charge me!");
        }

        public override void Drive()
        {
            Console.WriteLine("Pshhhhhh...");
        }
    }

    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("Fuel low...I need gas!");
        }

        public override void Drive()
        {
            Console.WriteLine("Whoooshhh...");
        }
    }

    public class Tesla : Vehicle
    {
        public double BatteryKwh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Battery low...take me to a supercharger now!");
        }

        public override void Drive()
        {
            Console.WriteLine("Cricket...cricket...");
        }
    }

    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("Low fuel...just dispose of me!");
        }

        public override void Drive()
        {
            Console.WriteLine("Cough...cough...global warming");
        }
    }

}