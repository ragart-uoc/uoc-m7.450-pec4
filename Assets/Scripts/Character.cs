using UnityEngine;

namespace M7450
{
    /// <summary>
    /// Class <c>Character</c> represents the character.
    /// </summary>
    public class Character : MonoBehaviour
    {
        /// <value>Property <c>exitPanel</c> represents the Canvas element containing the exit panel.</value>
        public GameObject exitPanel;
        
        /// <summary>
        /// Method <c>OnTriggerEnter</c> is called when the Collider other enters the trigger.
        /// </summary>
        /// <param name="other">The other Collider involved in this collision.</param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("ExitArea"))
            {
                exitPanel.SetActive(true);
            }
        }
        
        /// <summary>
        /// Method <c>OnTriggerExit</c> is called when the Collider other has stopped touching the trigger.
        /// </summary>
        /// <param name="other">The other Collider involved in this collision.</param>
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("ExitArea"))
            {
                exitPanel.SetActive(false);
            }
        }

        /// <summary>
        /// Method <c>QuitGame</c> is used to quit the game.
        /// </summary>
        public void QuitGame()
        {
            Application.Quit();
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }
    }
}
