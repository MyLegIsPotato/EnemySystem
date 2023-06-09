using ScriptableObjects;

namespace Interfaces.WeaponUsers
{
    public interface IExplosiveUser
    {
        Weapon ExplosiveWeapon { get; set; }
        ExplosiveSettings ExplosiveSettings { get; set; }
        
        void StartTimer();
        void Detonate();
    }
}