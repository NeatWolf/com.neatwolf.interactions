using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeatWolf.Interactions
{
    /// <summary>
    /// ScriptableObject defining a type of interaction within the game.
    /// Create instances of this asset to define different interaction behaviors, crosshairs, colors, etc.
    /// Link to the corresponding InteractableBase implementations.
    /// </summary>
    public class InteractionType : ScriptableObject
    {
        public Sprite crosshair;
        public Color crosshairColor;
        
        public virtual void Execute(GameObject actor, InteractableBase target) { }
        public virtual void PlaySound(Object sound, InteractionState state, Vector3? position = null) { }
    }
}
