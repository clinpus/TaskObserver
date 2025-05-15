
using System;

namespace TaskObserver
{
    public class Vehicle
    {

        public int Id { get; set; } 

        public void DriveForward()
        {
            Console.WriteLine("Vehicle Avance");
        }


        public void Stop()
        {
            Console.WriteLine("Vehicle Arrète");
        }

    }
}
