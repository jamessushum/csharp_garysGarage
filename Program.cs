using System;
using System.Collections.Generic;

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
            fx.Turn("sharp left turn to the express lane");
            fx.Stop();
            Console.WriteLine();
            oneSevenTwo.Drive();
            oneSevenTwo.Turn("nose dive into the pacific ocean");
            oneSevenTwo.Stop();
            Console.WriteLine();
            modelS.Drive();
            modelS.Turn("U turn into the wrong side of the road");
            modelS.Stop();
            Console.WriteLine();
            fifteenHundred.Drive();
            fifteenHundred.Turn("detour to the dirt road");
            fifteenHundred.Stop();
            Console.WriteLine();

            // List of electric vehicles
            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                fx,
                modelS
            };

            Console.WriteLine("Electric Vehicles");

            // Lists current battery level for each electric vehicle
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Battery Level: {ev.CurrentChargePercentage}%");
            }

            // Invokes ChargeBattery() method on each electric vehicle
            foreach (IElectricVehicle ev in electricVehicles)
            {
                ev.ChargeBattery();
            }

            // Lists battery level after invoking ChargeBattery() method
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"New Battery Level: {ev.CurrentChargePercentage}%");
            }
        }
    }

    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKwh { get; set; }

        public int CurrentChargePercentage { get; set; } = 0;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine("The highlighter yellow Zero zips by you. Pshhhhhh...");
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
            Console.WriteLine("The slate grey Cessna flies by you. Whoooshhh...");
        }

        public override void Stop()
        {
            Console.WriteLine("Then gently rolls to a stop before taking a swim.");
        }
    }

    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKwh { get; set; }

        public int CurrentChargePercentage { get; set; } = 0;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine("The royal blue Tesla slips by you. Cricket...cricket...");
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
            Console.WriteLine("The firetruck red Ram growls by you. Cough...cough...global warming");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Makes a {direction} before encountering a small pebble");
        }
    }

}