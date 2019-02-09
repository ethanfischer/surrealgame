using UnityEngine;

namespace Assets.Scripts.PlayerScripts
{
    public class Player : MonoBehaviour
    {
        public PlayerInventoryVR Inventory; 

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

        public void SetPosition (Vector3 v)
        {
            this.transform.position = v;
        }
    }
}
