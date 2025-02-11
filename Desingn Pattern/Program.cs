using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desingn_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            Singleton singleton1 = Singleton.GetInstance();
            //Singleton singleton2 = new Singleton(); // not allowd to create new instance
            Console.WriteLine(singleton.GetHashCode());
            Console.WriteLine(singleton1.GetHashCode());
            

            ////////////////// Factory Design Pattern //////////////////////
            ///
            Console.WriteLine("Enter Vehicale Type");
            string userinput = Console.ReadLine();
            IVehicale Type = VehicalFactory.GetVehicale(userinput);
            Console.WriteLine("Vahicale Type Is : "+Type.VehicaleType());
            Console.WriteLine("Number of Wheels : "+Type.NumberOfWheels());

            Console.ReadKey();
        }
    }
}
