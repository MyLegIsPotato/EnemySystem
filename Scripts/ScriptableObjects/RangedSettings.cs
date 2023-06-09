using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "RangedSettings", menuName = "ScriptableObjects/RangedSettings", order = 1)]
    public class RangedSettings : ScriptableObject
    {
        public int AttackDamage = 1;
        public float AttackRange = 1f;
        public float AttackInterval = 0.5f;
        public int MaxAmmo = 16;
        public AnimationCurve BulletDropCurve;
    }
}