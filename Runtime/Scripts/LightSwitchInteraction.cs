using UnityEngine;
using UnityEngine.Serialization;

namespace NeatWolf.Interactions
{
    /// <summary>
    /// Example class to handle light switch interactions.
    /// Extend this class for specific light switch behavior and sound effects.
    /// Use the PlaySound method to play sounds using the SoundSystem class.
    /// </summary>
    [CreateAssetMenu(menuName = "Interactions/Light Switch")]
    public class LightSwitchInteraction : InteractionType
    {
        public Object switchOnSound; // This can be AudioClip or AudioObject
        public Object switchOffSound; // This can be AudioClip or AudioObject
        [FormerlySerializedAs("soundSystem")] public SoundSystemImplementation soundSystemImplementation;

        public override void Execute(GameObject actor, InteractableBase target)
        {
            LightSwitchState switchState = target.GetState<LightSwitchState>();
            if (switchState != null)
            {
                switchState.isOn = !switchState.isOn;
                target.GetComponent<Light>().enabled = switchState.isOn;
                PlaySound(null, switchState, target.transform.position);
            }
        }

        public override void PlaySound(Object sound, InteractionState state, Vector3? position = null)
        {
            bool isOn = (state as LightSwitchState)?.isOn ?? false;
            SoundSystem.PlaySound(isOn ? switchOnSound : switchOffSound, position);
        }

    }

}