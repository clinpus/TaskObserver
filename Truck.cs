using System;

namespace TaskObserver
{
    public class Truck : Vehicle, IObservateur
    {

        public void Actualiser(ISujet sujet)
        {

            if (sujet.ColorForVehicle == TrafficLight.TrafficLightColor.Green)
            {
                Console.WriteLine("Camion, le feu passe au  " + sujet.ColorForVehicle + " , Merci ");
                this.DriveForward();
            }
            else if (sujet.ColorForVehicle == TrafficLight.TrafficLightColor.Red)
            {
                Console.WriteLine("Camion, le feu passe au  " + sujet.ColorForVehicle.ToString() + " , Merci ");
                this.Stop();
            }

        }
    }
}
