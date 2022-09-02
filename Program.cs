using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Electrical_Devices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio(false, "Samsung");

            radio.listenToRadio();
            radio.turnOn();
            radio.listenToRadio();
            radio.turnOff();

            TV television = new TV(false, "Roku");

            television.WatchTV();
            television.turnOn();
            television.WatchTV();
            television.turnOff();

            Console.ReadKey();
        }
    }
}
