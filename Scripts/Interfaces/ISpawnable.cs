using System;

namespace Interfaces
{
    public interface ISpawnable
    {
        event Action OnSpawned;
        event Action OnDespawned;
    
        void Activate();
        void Deactivate();
    }
}