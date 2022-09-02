using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Electrical_Devices
{
    internal class Radio : Electrical_Device
    {
        //Child Class
        public Radio(bool IsOn, string Brand) : base(IsOn, Brand)
        {

        }
        public void listenToRadio()
        {
            if (IsOn)            //check if radio is on
            {
                Console.WriteLine("La la la la");   //Listen to beautiful 
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("...");
                    Task.Delay(3000).Wait();

                }
                Console.WriteLine();
            }
        }
        

    }
}
