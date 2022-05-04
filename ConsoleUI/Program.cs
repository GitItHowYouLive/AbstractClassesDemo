using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var garage = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Car geo = new Car() { Color = "silver", Make = "Mazda", Model = "Mirage", Year = "2015", SubWoofer = false };
            Motorcycle klaus = new Motorcycle() { Year="2004", Make="BMW", Model="K1200GT", EngineSize=1196, Style="sport touring"};
            Vehicle tiff = new Car() { Color = "black", Make="Toyota", Model = "Rav 4", SubWoofer=false, Year="2015" };
            Vehicle backup = new Motorcycle() { Year="2008", Make="Kawasaki", Model="Versys", EngineSize=649, Style="adventure"};

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            garage.Add(geo);
            garage.Add(tiff);
            garage.Add(backup);
            garage.Add(klaus);

            foreach (Vehicle v in garage)
            {
                Console.WriteLine();
                foreach (var prop in v.GetType().GetProperties())
                {
                    Console.WriteLine($"{prop.Name}: {prop.GetValue(v, null)}");
                }
            }
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadKey();
        }
    }
}
