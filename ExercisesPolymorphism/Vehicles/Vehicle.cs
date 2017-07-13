using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelconsumptionInlitersPerKm;

        public Vehicle(double fuelQuantity, double fuelconsumptionInlitersPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelconsumptionInlitersPerKm = fuelconsumptionInlitersPerKm;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public double FuelconsumptionInlitersPerKm
        {
            get { return this.fuelconsumptionInlitersPerKm; }
            set { this.fuelconsumptionInlitersPerKm = value; }
        }


        public virtual void ReFuel(double fuel)
        {
            this.FuelQuantity += fuel;
        }

        public virtual string DriveDistance(double distance)
        {
            double neededFuel = distance * this.FuelconsumptionInlitersPerKm;
            if (this.FuelQuantity < neededFuel)
            {
                throw new OperationCanceledException($"{GetType().Name} needs refueling");
            }
            this.FuelQuantity -= neededFuel;
            return $"{GetType().Name} travelled {distance} km";
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
