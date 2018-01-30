using UnityEngine;
using System.Collections;

namespace SurrealGame
{

    public class ItemSoundEffect : MonoBehaviour
    {
        public AudioSource sfx1;

        // Use this for initialization
        void Start()
        {
            SetInitialReferences();

        }

        // Update is called once per frame
        void Update()
        {

        }

        void SetInitialReferences()
        {
        }

        public void PlaySoundEffect()
        {
            //Debug.Log (gameObject.name);
            sfx1.Play();
        }


    }
}

