using Assets.Scripts.PlayerScripts;
using UnityEngine;

namespace Assets.Scripts.ExtensionsAndUtilities
{
    public static class GameObjectExtensions
    {
        public static void ComplainIfNull(this GameObject gameObject)
        {
            if (gameObject == null)
            {
                Debug.LogError("GameObject not assigned in editor:" + gameObject.name);
            }
        }

        public static bool IsPlayer(this Collider collider)
        {
            if (collider.gameObject.GetComponentInParent<Player>())
            {
                return true;
            }

            return false;
        }
    }
}
