using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desingn_Pattern
{
    public class Car : IVehicale
    {
        private readonly int _Wheels;
        public Car()
        {
            this._Wheels=4;
        }
        public int NumberOfWheels()
        {
            return this._Wheels;
        }

        public string VehicaleType()
        {
            return "Car";
        }
    }
}
