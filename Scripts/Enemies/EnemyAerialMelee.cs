using Abstracts;
using Interfaces.Movement;
using Interfaces.WeaponUsers;
using ScriptableObjects;

namespace Enemies
{
    public class EnemyAerialMelee : Enemy, IMovableAerial, IMeleeUser
    {
        public Weapon MeleeWeapon { get; set; }
        public MeleeSettings MeleeSettings { get; set; }
        public float FlightHeight { get; set; }
        
        public void Strike()
        {
            throw new System.NotImplementedException();
        }

        public void Parry()
        {
            throw new System.NotImplementedException();
        }

        public void Descent()
        {
            throw new System.NotImplementedException();
        }

        public void Ascent()
        {
            throw new System.NotImplementedException();
        }

        public override void Activate()
        {
            throw new System.NotImplementedException();
        }

        public override void Deactivate()
        {
            throw new System.NotImplementedException();
        }
    }
}