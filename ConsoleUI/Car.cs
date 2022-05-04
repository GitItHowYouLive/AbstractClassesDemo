using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public string Color { get; set; }
        public bool SubWoofer { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("I'm justa rolling along!");
        }
    }
}
