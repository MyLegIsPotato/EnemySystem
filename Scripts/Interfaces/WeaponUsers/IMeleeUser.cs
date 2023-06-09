using ScriptableObjects;

namespace Interfaces.WeaponUsers
{
    public interface IMeleeUser
    {
        Weapon MeleeWeapon { get; set; }
        MeleeSettings MeleeSettings { get; set; }
        
        void Strike();
        void Parry();
    }
}