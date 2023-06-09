using Abstracts;
using Interfaces.Movement;
using Interfaces.WeaponUsers;
using ScriptableObjects;

namespace Enemies
{
    public class EnemyAerialExplosive : Enemy, IMovableAerial, IExplosiveUser
    {
        public Weapon ExplosiveWeapon { get; set; }
        public ExplosiveSettings ExplosiveSettings { get; set; }
        public float FlightHeight { get; set; }
        
        public void StartTimer()
        {
            throw new System.NotImplementedException();
        }

        public void Detonate()
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