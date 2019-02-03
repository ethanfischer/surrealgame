using UnityEngine;

namespace Assets.Scripts
{
    public class PlaySound : MonoBehaviour
    {
        public void Play()
        {
            gameObject.GetComponentInChildren<AudioSource>().Play();
        }
    }
}
