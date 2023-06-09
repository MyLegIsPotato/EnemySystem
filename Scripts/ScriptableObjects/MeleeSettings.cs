using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "MeleeSettings", menuName = "ScriptableObjects/MeleeSettings", order = 1)]
    public class MeleeSettings : ScriptableObject
    {
        public int AttackDamage = 1;
        public float AttackRange = 1f;
        public float AttackInterval = 0.5f;
    }
}