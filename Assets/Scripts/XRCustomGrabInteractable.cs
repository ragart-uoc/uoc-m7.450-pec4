using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace M7450
{
    /// <summary>
    /// Class <c>XRCustomGrabInteractable</c> is a custom XRGrabInteractable that allows for custom attach points for each hand.
    /// </summary>
    public class XRCustomGrabInteractable : XRGrabInteractable
    {
        /// <value>Property <c>leftHandAttachTransform</c> represents the left hand attach point.</value>
        [SerializeField]
        private Transform leftHandAttachTransform;
        
        /// <value>Property <c>rightHandAttachTransform</c> represents the right hand attach point.</value>
        [SerializeField]
        private Transform rightHandAttachTransform;
        
        /// <value>Property <c>leftController</c> represents the left hand controller.</value>
        [SerializeField]
        private XRBaseInteractor leftController;
        
        /// <value>Property <c>rightController</c> represents the right hand controller.</value>
        [SerializeField]
        private XRBaseInteractor rightController;
 
        /// <value>Property <c>_originalAttachTransform</c> represents the original attach point.</value>
        private Transform _originalAttachTransform;

        /// <summary>
        /// Method <c>Awake</c> is called when the script instance is being loaded.
        /// </summary>
        protected override void Awake()
        {
            _originalAttachTransform = attachTransform;
            base.Awake();
        }

        /// <summary>
        /// Method <c>GetAttachTransform</c> returns the attach point for the given interactor.
        /// </summary>
        /// <param name="interactor">The interactor to get the attach point for.</param>
        public override Transform GetAttachTransform(IXRInteractor interactor)
        {
            if ((XRBaseInteractor)interactor == leftController)
                return leftHandAttachTransform;
            else if ((XRBaseInteractor)interactor == rightController)
                return rightHandAttachTransform;
            else
                return _originalAttachTransform;
        }
    }
}
