using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class SFX : MonoBehaviour
    {
        public AudioSource AddToInventory;
        public Dictionary<SoundEffectType, AudioSource> SoundEffects;

        private static SFX _instance = null;
        public static SFX Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.FindObjectOfType<SFX>();
                }

                return _instance;
            }
        }


        public enum SoundEffectType
        {
            AddToInventory
        }


        void Start()
        {
            SoundEffects = new Dictionary<SoundEffectType, AudioSource>
            {
                 {SoundEffectType.AddToInventory, AddToInventory}
            };
        }

        public void PlaySoundEffect(SoundEffectType soundEffectType)
        {
            SoundEffects[soundEffectType].Play();
        }

    }
}

