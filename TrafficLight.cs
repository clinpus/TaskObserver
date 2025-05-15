using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskObserver
{
    public  class TrafficLight : ISujet
    {
        public enum TrafficLightColor
        {
            Red, 
            Green, 
            Orange
        }

        private List<IObservateur> _observateurs = new List<IObservateur>();

        public TrafficLightColor ColorForVehicle { get; set; }

        public async Task ChangeColor()
        {
            await SetColor();
        }

        public async Task SetColor()
        {
            while (true)
            {
                await WaitColorChange();
                ColorForVehicle = TrafficLightColor.Red;
                NotifierObservateursFeu();
                await WaitColorChange();
                ColorForVehicle = TrafficLightColor.Green;
                NotifierObservateursFeu();
            }
        }

        public async Task WaitColorChange()
        {
            int i = 0;
            while (i < 4)
            {
                i++;
                Console.WriteLine("J'attend que le feu change.");
                await Task.Delay(1000);
            }
            
        }

            public void AjouterObservateur(IObservateur observateur)
        {
            _observateurs.Add(observateur);
        }

        public void SupprimerObservateur(IObservateur observateur)
        {
            _observateurs.Remove(observateur);
        }

        public void NotifierObservateursFeu()
        {
            foreach (var observateur in _observateurs)
            {
                observateur.Actualiser(this);
            }
        }
    }
}
