using System;

namespace gary_garage
{
  public class Vehicle
  {
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
      Console.WriteLine("Vrooom!");
    }

    public virtual void Turn(string direction)
    {
      Console.WriteLine($"Makes a {direction}");
    }

    public virtual void Stop()
    {
      Console.WriteLine("Then gently rolls to a stop.");
    }
  }

}