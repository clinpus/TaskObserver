using static TaskObserver.TrafficLight;

namespace TaskObserver
{
    public interface ISujet
    {
        TrafficLightColor ColorForVehicle { get; set; }
        void AjouterObservateur(IObservateur observateur);
        void SupprimerObservateur(IObservateur observateur);
        void NotifierObservateursFeu();
    }
}
