using UnityEngine;

namespace NeatWolf.Interactions
{
    /// <summary>
    /// Unity's sound system implementation.
    /// This class casts the sound object to an AudioClip and plays it.
    /// Create this ScriptableObject from the Assets menu under "Sound Systems/Unity Sound System."
    /// </summary>
    [CreateAssetMenu(menuName = "Sound Systems/Unity Sound System")]
    public class UnitySoundSystem : ScriptableObject
    {
        public void PlaySound(Object sound, Vector3? position = null)
        {
            AudioClip clip = sound as AudioClip;
            if (clip != null)
            {
                if (position.HasValue)
                    AudioSource.PlayClipAtPoint(clip, position.Value);
            }
        }
    }

}