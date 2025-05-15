using System;

namespace TaskObserver
{
    public class Pedestrian : IObservateur
    {
        public void Actualiser(ISujet sujet)
        {
            Console.WriteLine("Piéton, le feu des véhicules passe au  " + sujet.ColorForVehicle + " , Merci ");
            if (sujet.ColorForVehicle == TrafficLight.TrafficLightColor.Green)
            {
                this.WaitGreenLight();
            }
            else if (sujet.ColorForVehicle == TrafficLight.TrafficLightColor.Red)
            {
                this.GoForward();
            }
        }

        public void  GoForward()
        {
            Console.WriteLine("Piéton avance, le feu est rouge pour les véhicules.");
        }

        public void WaitGreenLight()
        {
            Console.WriteLine("Piéton attend le feu est vert pour les véhicules.");
        }
    }
}
