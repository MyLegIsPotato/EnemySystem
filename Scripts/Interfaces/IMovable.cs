using UnityEngine;

namespace Interfaces
{
    public interface IMovable
    {
        float Speed { get; set; }
        
        void Move(Vector3 direction);
        void SetTarget(Transform target);
        void Stop();
    }
}