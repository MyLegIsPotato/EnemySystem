using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "ExplosiveSettings", menuName = "ScriptableObjects/ExplosiveSettings", order = 1)]
    public class ExplosiveSettings : ScriptableObject
    {
        public int AttackDamage = 100;
        public float ExplosionRadius = 1f;
        public int ClusterCount = 4;
        public int ClusterDamage = 25;
        public float ClusterRadius = 1f;
    }
}