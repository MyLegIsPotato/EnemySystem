using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "EnemySettings", menuName = "ScriptableObjects/EnemySettings", order = 1)]
    public class EnemySettings : ScriptableObject
    {
        public int Health;
        public float Speed;
        public string Classname = "DefaultClass";
        public List<AudioClip> AttackSFXs = new();
        public List<ParticleSystem> AttackVFXs = new();
        public DeathSettings DeathSettings;
    }
}