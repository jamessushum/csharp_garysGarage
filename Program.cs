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

    public class Tesla : Vehicle
    {
        public double BatteryKwh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Battery low...take me to a supercharger now!");
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