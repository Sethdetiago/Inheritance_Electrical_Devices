using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Electrical_Devices
{
    internal class TV : Electrical_Device
    {
        //Child Class
        public TV(bool IsOn, string Brand) : base(IsOn, Brand)
        {

        }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("...");
                    Task.Delay(3000);
                }
                Console.WriteLine("");

            }
        }
    }
}
