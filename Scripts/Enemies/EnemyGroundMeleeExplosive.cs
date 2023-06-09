using Abstracts;
using Interfaces;
using Interfaces.WeaponUsers;
using ScriptableObjects;

namespace Enemies
{
    public class EnemyGroundMeleeExplosive : Enemy, IMeleeUser, IExplosiveUser
    {
        private ExplosiveSettings settings;
        public Weapon MeleeWeapon { get; set; }
        public MeleeSettings MeleeSettings { get; set; }
        public Weapon ExplosiveWeapon { get; set; }
        
        ExplosiveSettings IExplosiveUser.ExplosiveSettings
        {
            get => settings;
            set => settings = value;
        }
        
        public void StartTimer()
        {
            throw new System.NotImplementedException();
        }

        public void Detonate()
        {
            throw new System.NotImplementedException();
        }

        public void Strike()
        {
            throw new System.NotImplementedException();
        }

        public void Parry()
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