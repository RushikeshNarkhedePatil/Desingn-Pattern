using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desingn_Pattern
{
    public class Bike : IVehicale
    {
        private readonly int _Wheels;
        public Bike()
        {
            this._Wheels = 2;
        }
        public int NumberOfWheels()
        {
            return this._Wheels;
        }

        public string VehicaleType()
        {
            return "Bike";
        }
    }
}
