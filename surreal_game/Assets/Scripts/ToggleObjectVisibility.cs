using Assets.Scripts.ExtensionsAndUtilities;
using UnityEngine;

namespace Assets.Scripts
{
    public class ToggleObjectVisibility : MonoBehaviour
    {
        public GameObject Lens;

        void Start()
        {
            SetInitialReferences();
        }

        private void SetInitialReferences()
        {
            Lens.ComplainIfNull();
        }

        void OnTriggerEnter()
        {
            Lens.SetActive(false);
        }

        void OnTriggerExit()
        {
            Lens.SetActive(true);
        }
    }
}
