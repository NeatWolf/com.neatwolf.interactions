using UnityEngine;

namespace NeatWolf.Interactions
{
    [RequireComponent(typeof(Light), typeof(AudioSource))]
    public class LightSwitchObject : InteractableBase
    {
        private void Awake()
        {
            state = new LightSwitchState();
            // Restore state logic here
        }
    }
}