using UnityEngine;
using UnityEngine.UI;

namespace NeatWolf.Interactions
{
    /// <summary>
    /// Manages the user interface elements related to interactions.
    /// Attach this script to a dedicated UI manager GameObject and link to the necessary UI elements, such as crosshairs.
    /// Coordinates with PlayerInteractionHandler to display interaction-related information.
    /// </summary>
    public class InteractionUIManager : MonoBehaviour
    {
        [SerializeField]
        private Image crosshairImage;

        public void ShowInteractionUI(InteractionType interaction)
        {
            crosshairImage.sprite = interaction.crosshair;
            crosshairImage.color = interaction.crosshairColor;
        }
    }

}