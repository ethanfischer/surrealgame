using System.Collections;
using System.Collections.Generic;
using System.Media;
using Assets.Scripts.Miscellaneous;
using UnityEngine;

public class DestroyObjectsWithTag : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        var go = collider.gameObject;
        if (go.tag == Tags.DISPOSABLE)
        {
            SystemSounds.Asterisk.Play();
            GameObject.Destroy(go);
        }
    }
}
