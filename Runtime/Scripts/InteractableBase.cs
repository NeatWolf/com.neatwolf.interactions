using UnityEngine;

namespace NeatWolf.Interactions
{
    /// <summary>
    /// Base class for all interactable objects within the game.
    /// Extend this class to define specific interactions like doors, switches, pick-ups, etc.
    /// Implement the required interaction logic and link to necessary assets like sound effects.
    /// </summary>
    public class InteractableBase : MonoBehaviour
    {
        [SerializeField]
        protected InteractionType interaction;
        [SerializeField, HideInInspector] protected InteractionState state;

        public InteractionType Interaction => interaction;

        public void Interact(GameObject actor)
        {
            interaction.Execute(actor, this);
        }

        public T GetState<T>() where T : InteractionState
        {
            return state as T;
        }
    }

}