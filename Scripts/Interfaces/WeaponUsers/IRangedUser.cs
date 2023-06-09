using ScriptableObjects;

namespace Interfaces.WeaponUsers
{
    public interface IRangedUser
    {
        Weapon RangedWeapon { get; set; }
        RangedSettings RangedSettings { get; set; }
        
        void Aim();
        void Shoot();
        void Reload();
    }
}