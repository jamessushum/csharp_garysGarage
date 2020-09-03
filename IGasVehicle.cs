namespace gary_garage
{
  public interface IGasVehicle
  {
    double FuelCapacity { get; set; }

    int CurrentTankPercentage { get; set; }

    void RefuelTank();
  }
}