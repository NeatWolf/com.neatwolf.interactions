using UnityEngine;

namespace NeatWolf.Interactions
{
    /// <summary>
    /// A centralized class responsible for sound playback throughout the project.
    /// Attach this script to a GameObject (preferably a singleton manager object) in the scene.
    /// Assign a SoundSystemImplementation ScriptableObject to configure the sound playback behavior.
    /// </summary>
    public class SoundSystem : MonoBehaviour
    {
        protected static SoundSystem instance;

        [SerializeField]
        private SoundSystemImplementation soundImplementation;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public static void PlaySound(Object sound, Vector3? position = null)
        {
            instance.soundImplementation.PlaySound(sound, position);
        }
    }

}