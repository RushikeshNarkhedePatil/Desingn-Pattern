using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desingn_Pattern
{
    class VehicalFactory
    {
        public static IVehicale GetVehicale(string objType)
        {
            IVehicale objectType =null;
            if(objType.ToLower().Equals("bike"))
            {
                objectType = new Bike();
            }
            else if (objType.ToLower().Equals("car"))
            {
                objectType = new Car();
            }
            return objectType;
        }
    }
}
