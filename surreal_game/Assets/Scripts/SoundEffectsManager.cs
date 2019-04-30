using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class SoundEffectsManager : MonoBehaviour
    {
        private static SoundEffectsManager _instance = null;
        public static SoundEffectsManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.FindObjectOfType<SoundEffectsManager>();
                }

                return _instance;
            }
        }
        public AudioClip[] AudioClips;
        public AudioSource AudioSource;

        public enum AudioClipType
        {
            Unlock = 0,
            ItemPickup = 1,
            Lock = 2,
            Doorbell = 3
        }

        public static void Play(AudioClipType sfxType)
        {
            Instance.PlaySfx(sfxType);
        }

        private void PlaySfx(AudioClipType sfxType)
        {
            Debug.Log(sfxType);
            AudioSource.clip = AudioClips[Convert.ToInt32(sfxType)];
            Debug.Log(AudioSource);
            AudioSource.Play();
        }
    }
}
