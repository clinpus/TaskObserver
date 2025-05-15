using System;

namespace TaskObserver
{
    public class Care : Vehicle, IObservateur
    {
        public void Actualiser(ISujet sujet)
        {
            if (sujet.ColorForVehicle == TrafficLight.TrafficLightColor.Green) {
                Console.WriteLine("Voiture, le feu passe au  " + sujet.ColorForVehicle.ToString() + " , Merci ");
                this.DriveForward();
            }
            else if (sujet.ColorForVehicle == TrafficLight.TrafficLightColor.Red)
            {
                Console.WriteLine("Voiture, le feu passe au  " + sujet.ColorForVehicle.ToString() + " , Merci ");
                this.Stop();
            }

        }
    }
}
