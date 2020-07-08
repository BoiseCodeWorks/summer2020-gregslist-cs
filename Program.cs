using System;
using System.Collections.Generic;
using gregslist_cs.Models;

namespace gregslist_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Automobile> autos = new List<Automobile>();




            Motorcycle m = new Motorcycle(true, BrakeSystem.flinstone, "Dirtbike", "It's great on da trail", 1999, 100000, "Yamahaa", "Hehaw2000");

            Truck t = new Truck("Tracker", "It's great on da trail", 1999, 100000, "D$", "Da Tracker", 32.2, "yup");

            // NOTE Implicit casting
            autos.Add(m);
            autos.Add(t);


            foreach (Automobile a in autos)
            {
                Console.WriteLine(a.Title);
                Console.WriteLine(a.Start());
                // if (a is Motorcycle)
                // {
                //     // NOTE Explicit
                //     var aMotorcycle = (Motorcycle)a;
                //     if (aMotorcycle.KickStart)
                //     {
                //         Console.Beep();
                //     }
                // }

                var aMotorcycle = a as Motorcycle;
                if (aMotorcycle != null)
                {
                    // NOTE Explicit
                    if (aMotorcycle.KickStart)
                    {
                        Console.Beep();
                    }
                }
            }
        }
    }
}
