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

            // Lists battery level for each electric vehicle after invoking ChargeBattery() method
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"New Battery Level: {ev.CurrentChargePercentage}%");
            }

            Console.WriteLine();

            // List of gas vehicles
            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                oneSevenTwo,
                fifteenHundred
            };

            Console.WriteLine("Gas Vehicles");

            // Lists current fuel level for each gas vehicle
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Current Fuel Level: {gv.CurrentTankPercentage}%");
            }

            // Invokes RefuelTank() method on each gas vehicle
            foreach (IGasVehicle gv in gasVehicles)
            {
                gv.RefuelTank();
            }

            // Lists fuel level for each gas vehicle after invoking RefuelTank() method
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"New Fuel Level: {gv.CurrentTankPercentage}%");
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

    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; } = 0;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
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

    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; } = 0;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
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