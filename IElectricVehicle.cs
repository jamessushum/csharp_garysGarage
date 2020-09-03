namespace gary_garage
{
  public interface IElectricVehicle
  {
    double BatteryKwh { get; set; }

    int CurrentChargePercentage { get; set; }

    void ChargeBattery();
  }
}