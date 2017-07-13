﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelconsumptionInlitersPerKm, double tankCapacity)
            : base(fuelQuantity, fuelconsumptionInlitersPerKm, tankCapacity)
        {
            this.FuelconsumptionInlitersPerKm += 0.9;
        }
    }
}
