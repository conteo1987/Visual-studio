using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelconsumptionInlitersPerKm, double tankCapacity)
            : base(fuelQuantity, fuelconsumptionInlitersPerKm, tankCapacity)
        {
            this.FuelconsumptionInlitersPerKm += 1.6;
        }


        public override void ReFuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += fuel * 0.95;
        }

    }
}
