using UnityEngine;

namespace NeatWolf.Interactions
{
    /// <summary>
    /// A custom sound system implementation tailored to your specific needs.
    /// This class casts the sound object to an AudioObject and plays it using your custom sound system.
    /// Create this ScriptableObject from the Assets menu under "Sound Systems/Custom Sound System."
    /// </summary>
    [CreateAssetMenu(menuName = "Sound Systems/NeatWolf System")]
    public class NeatWolfSoundSystem : SoundSystemImplementation
    {
        public override void PlaySound(Object sound, Vector3? position = null)
        {
            /*AudioObject audioObject = sound as AudioObject;
            if (audioObject != null)
            {
                // Logic to play the AudioObject using your sound system
            }*/
        }
    }


}