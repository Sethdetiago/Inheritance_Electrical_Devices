using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Electrical_Devices
{
    internal class Electrical_Device
    {
        //Parent Class - Base
        public bool IsOn { get; set; }

        private string Brand { get; set; }

        public Electrical_Device(bool IsOn, string Brand)
        {
            this.IsOn = IsOn;
            this.Brand = Brand;
        }

        public void turnOn()
        {
            IsOn = true;
            Console.WriteLine("Device is now on \n Welcome {0} ", Brand);
        }

        public void turnOff()
        {
            IsOn = false;
            Console.WriteLine("Device Shutting down...");
        }
        



    }
}
