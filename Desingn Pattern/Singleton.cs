using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desingn_Pattern
{
    /// <summary>
    /// one class one intanse or object and use same object in entier application
    /// sealed class is non inharitable.
    /// lock is used to avoid acess in one time at time of multithreading, because incase at one time acess both thread and this time instance will be
    /// null then this time both thread created instance and break sinleton pattern rule. to avoid this senareo use lock.
    /// lock is avoid to acess at time both thread, incase use lock then after completed first thread then allows second thread.
    /// </summary>
    sealed class Singleton
    {
        private static Singleton Instance;
        private static object InstanceLock = new object();
        private Singleton()
        {

        }
        // create one static method to use global access point in throuthout the application
        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                lock (InstanceLock)
                {
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                    }
                }
            }
            return Instance;
        }
    }
}
