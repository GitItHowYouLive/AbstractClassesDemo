using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        private string _year = "2022";

        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private string _make = "Generic";

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        private string _model = "Vehicle";

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"It's headed forward!");
        }
    }
}
