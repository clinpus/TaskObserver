using System;

namespace TaskObserver
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programme Implementation design patern Observer");

            TrafficLight tlightForVehicle = new TrafficLight();

            Truck  c = new Truck();
            Care v = new Care();
            Pedestrian p = new Pedestrian();

            // Les observateurs s'abonnent au sujet
            tlightForVehicle.AjouterObservateur(c);
            tlightForVehicle.AjouterObservateur(v);
            tlightForVehicle.AjouterObservateur(p);

            tlightForVehicle.ChangeColor();

            Console.ReadLine();
        }
    }
}
