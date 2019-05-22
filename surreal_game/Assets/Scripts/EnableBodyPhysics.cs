using Assets.Scripts.PlayerScripts;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnableBodyPhysics : MonoBehaviour
    {
        public void Do()
        {
            Player.Instance.BodyPhysics.enabled = true;
        }
    }
}
