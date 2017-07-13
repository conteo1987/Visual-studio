namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelconsumptionInlitersPerKm) : base(fuelQuantity, fuelconsumptionInlitersPerKm)
        {
            this.FuelconsumptionInlitersPerKm += 0.9;
        }
    }
}
