using UnityEngine;

namespace Assets.Scripts
{
    public class GrabAction : MonoBehaviour
    {
        public SoundEffectsManager.AudioClipType SoundEffect;
        public bool IsOneShot = false;
        private int _grabCount = 0;

        public void PlaySoundEffect()
        {
            if (IsOneShot && _grabCount > 0) return;
            SoundEffectsManager.Play(SoundEffect);
            _grabCount++;
        }
    }
}
