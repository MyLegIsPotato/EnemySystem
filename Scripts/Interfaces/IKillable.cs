using Enums;

namespace Interfaces
{
    public interface IKillable
    {
        int Health { get; set; }
    
        void GetDamage(int damageAmount);

        void Die(DeathType deathType);
    }
}