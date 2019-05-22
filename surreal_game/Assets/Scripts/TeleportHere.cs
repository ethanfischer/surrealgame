using Assets.Scripts.PlayerScripts;
using UnityEngine;

namespace Assets.Scripts
{
    public class TeleportHere : MonoBehaviour
    {
        public GameObject ObjectToTeleport;
        public bool ShouldTeleportPlayer = false;

        public void Teleport()
        {
            if (ShouldTeleportPlayer)
            {
                Player.Instance.transform.SetPositionAndRotation(transform.position, transform.rotation);
            }
            else
            {
                ObjectToTeleport.transform.SetPositionAndRotation(transform.position, transform.rotation);
            }
        }
    }
}
