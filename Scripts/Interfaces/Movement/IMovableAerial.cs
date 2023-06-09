namespace Interfaces.Movement
{
    public interface IMovableAerial : IMovable
    {
        float FlightHeight { get; set; }

        void Descent();
        void Ascent();
    }
}