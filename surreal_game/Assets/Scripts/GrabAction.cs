using UnityEngine;

namespace Assets.Scripts
{
    public class GrabAction : MonoBehaviour
    {
        public SoundEffectsManager.AudioClipType SoundEffect;

        public void PlaySoundEffect()
        {
            SoundEffectsManager.Play(SoundEffect);
        }
    }
}
