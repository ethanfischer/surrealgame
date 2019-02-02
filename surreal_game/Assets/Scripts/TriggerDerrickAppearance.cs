using System.Media;
using Assets.Scripts.Miscellaneous;
using UnityEngine;

namespace Assets.Scripts
{
    public class TriggerDerrickAppearance : MonoBehaviour
    {
        public GameObject Derrick;

        void OnTriggerEnter(Collider collider)
        {
            var go = collider.gameObject;
            if (go.tag != Tags.DISPOSABLE) return;

            Derrick.SetActive(true);
        }
    }
}
