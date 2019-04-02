using Assets.Scripts.ExtensionsAndUtilities;
using UnityEngine;
using VRTK;

namespace Assets.Scripts.PlayerScripts
{
    public class Player : MonoBehaviour
    {
        public PlayerInventoryVR Inventory;
        public GameObject Avatar;
        public VRTK_SDKManager VRTK_SDKManager;

        private static Player _instance = null;
        public static Player Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.FindObjectOfType<Player>();
                }

                return _instance;
            }
        }

        public void SetPosition(Vector3 v)
        {
            this.transform.position = v;
        }

        private void Start()
        {
            Avatar.ComplainIfNull();
        }
    }
}
