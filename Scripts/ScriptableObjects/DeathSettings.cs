using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "DeathSettings", menuName = "ScriptableObjects/DeathSettings", order = 1)]
    public class DeathSettings : ScriptableObject
    {
        public AudioClip BurntSFX;
        public ParticleSystem BurntVFX;
        public AnimationClip BurntAnimation;
        public AudioClip DecapitatedSFX;
        public ParticleSystem DecapitatedVFX;
        public AnimationClip DecapitatedAnimation;
        public AudioClip ShotSFX;
        public ParticleSystem ShotVFX;
        public AnimationClip ShotAnimation;
        //Add more for more ways to die...
    }
}