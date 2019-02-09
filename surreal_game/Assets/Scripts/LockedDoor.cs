using Assets.Scripts.PlayerScripts;
using UnityEngine;

namespace Assets.Scripts
{
    public class LockedDoor : MonoBehaviour
    {
        void OnTriggerEnter()
        {
            if (Player.Instance.Inventory.HasItem("key"))
            {
                gameObject.SetActive(false);
            }
        }
    }
}

