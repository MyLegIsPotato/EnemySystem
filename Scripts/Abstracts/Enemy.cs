using System;
using Enums;
using Interfaces;
using ScriptableObjects;
using UnityEngine;

namespace Abstracts
{
    public abstract class Enemy : MonoBehaviour, ISpawnable, IMovable, IKillable
    {
        public string Name = "DefaultEnemy";
        public EnemySettings Settings;

        private Transform currentTarget;

        public event Action OnSpawned;
        public event Action OnDespawned;
        
        public int Health
        {
            get => Settings.Health;
            set => Settings.Health = value;
        }
        
        public float Speed
        {
            get => Settings.Speed;
            set => Settings.Speed = value;
        }

        public virtual void GetDamage(int damageAmount)
        {
            throw new NotImplementedException();
        }

        public virtual void Die(DeathType deathType)
        {
            //Show Settings.DeathSettings.Effects.../Play Audio
        }

        public virtual void Move(Vector3 direction)
        {
            //for example
            transform.position += direction * (Speed * Time.deltaTime);
        }

        public virtual void SetTarget(Transform target)
        {
            currentTarget = target;
        }

        public virtual void Stop()
        {
            throw new NotImplementedException();
        }

        public abstract void Activate();
        public abstract void Deactivate();
    }
}
