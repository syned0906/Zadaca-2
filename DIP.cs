using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    

    class Car
    {
        Engine engine;
        Car()
        {
            this.engine = new GasolineEngine(); 
        }

        void start()
        {
            engine.start();
        }
    }

   
    class GasolineEngine
    {
        void start()
        {
            Console.WriteLine("Engine starded");
        }
    }
}

// ovaj primjer narusava DIP jer clasa Car nebi trebala ovositi o klasi GasolineEngine() vec o abstraknoj klasi npr Engine 