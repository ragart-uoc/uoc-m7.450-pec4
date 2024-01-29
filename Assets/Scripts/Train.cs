using UnityEngine;

namespace M7450
{
    /// <summary>
    /// Class <c>Train</c> represents the train.
    /// </summary>
    public class Train : MonoBehaviour
    {
        /// <value>Property <c>audioSource</c> represents the AudioSource component.</value>
        [SerializeField]
        private AudioSource audioSource;

        [SerializeField]
        private float minZ;
        
        [SerializeField]
        private float maxZ;

        private void FixedUpdate()
        {
            var position = transform.position;
            // Check what percentage of the distance between minPosition and maxPosition the train has traveled.
            var percentage = (position.z - minZ) / (maxZ - minZ);
            // Set the volume of the audio source to the percentage.
            audioSource.volume = percentage;
        }
    }
}
