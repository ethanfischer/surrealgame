using System.Collections;
using System.Collections.Generic;
using System.Media;
using UnityEngine;

public class Interact : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponentInParent<Player>())
        {
            SystemSounds.Asterisk.Play();
            Debug.Log("!!!!!");
        }

    }
}
