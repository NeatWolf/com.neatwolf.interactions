using UnityEngine;

namespace NeatWolf.Interactions
{
    /// <summary>
    /// Abstract base class for sound system implementations.
    /// Derive from this class to create specific implementations of sound playback.
    /// Create the implementation as a ScriptableObject from the Assets menu.
    /// </summary>
    public abstract class SoundSystemImplementation : ScriptableObject
    {
        public abstract void PlaySound(Object sound, Vector3? position = null);
    }
}