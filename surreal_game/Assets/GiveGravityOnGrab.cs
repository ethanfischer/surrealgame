using Assets.Scripts.ExtensionsAndUtilities;
using UnityEngine;
using VRTK.UnityEventHelper;

namespace Assets
{
    public class GiveGravityOnGrab : MonoBehaviour {
        private Rigidbody RigidBody { get; set; }

        // Use this for initialization
        void Start ()
        {
            RigidBody = GetComponent<Rigidbody>();
            RigidBody.gameObject.ComplainIfNull();
        }

        public void GiveGravity()
        {
            RigidBody.useGravity = true;

            Debug.Log(RigidBody.isKinematic);
        }

        // Update is called once per frame
        void Update () {
		
        }
    }
}
