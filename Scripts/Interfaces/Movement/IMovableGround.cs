namespace Interfaces.Movement
{
    public interface IMovableGround : IMovable
    {
        float JumpForce { get; set; }
        float SprintTime { get; set; }

        void Run();
        void Jump();
    }
}