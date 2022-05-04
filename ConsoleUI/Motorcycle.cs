using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Vroom! Wheelie!! BraaAAAP!!!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Harley Time!: po-ta-to-po-ta-to-po-ta-to");
        }

        public int EngineSize { get; set; }
        public string Style { get; set; }
    }
}
