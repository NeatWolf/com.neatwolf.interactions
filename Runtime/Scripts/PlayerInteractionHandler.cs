using NeatWolf.FPS;
using UnityEngine;

namespace NeatWolf.Interactions
{
    /// <summary>
    /// Handles player interactions with in-game objects.
    /// Attach this script to the main player GameObject, and configure the interaction distance, raycasting, and other parameters.
    /// Works with interactable objects implementing the InteractableBase class.
    /// </summary>
    public class PlayerInteractionHandler : MonoBehaviour
    {
        [SerializeField]
        private float interactionDistance = 2f;
        [SerializeField]
        private InteractionUIManager uiManager;
        [SerializeField]
        private LayerMask interactionLayerMask;

        private PlayerControls controls;

        private void Awake()
        {
            controls = new PlayerControls();
            // Retrieve the "Interact" action by name from the desired action map
            var interactAction = controls.asset.FindAction("Interact");

            if (interactAction != null)
            {
                interactAction.performed += _ => Interact();
            }
            else
            {
                Debug.LogError("Interact action not found!");
            }
        }

        private void OnEnable() => controls.Enable();
        private void OnDisable() => controls.Disable();

        private void Interact()
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactionDistance, interactionLayerMask))
            {
                InteractableBase interactable = hit.collider.GetComponent<InteractableBase>();
                if (interactable != null)
                {
                    interactable.Interact(gameObject);
                    uiManager.ShowInteractionUI(interactable.Interaction);
                }
            }
        }
    }
}