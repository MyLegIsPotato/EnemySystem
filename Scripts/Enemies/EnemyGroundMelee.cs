using Abstracts;
using Interfaces.Movement;
using Interfaces.WeaponUsers;
using ScriptableObjects;

namespace Enemies
{
    public class EnemyGroundMelee : Enemy, IMovableGround, IMeleeUser
    {
        public Weapon MeleeWeapon { get; set; }
        public MeleeSettings MeleeSettings { get; set; }
        public float JumpForce { get; set; }
        public float SprintTime { get; set; }
        
        public void Strike()
        {
            throw new System.NotImplementedException();
        }

        public void Parry()
        {
            throw new System.NotImplementedException();
        }
        
        public void Run()
        {
            throw new System.NotImplementedException();
        }

        public void Jump()
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