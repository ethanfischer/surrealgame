using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkOverTime : MonoBehaviour {
    public float targetScale = 0.1f;
    public float shrinkSpeed = 0.1f;
    public bool shrinking;
	// Use this for initialization
	void Start () {
		
	}
	
    void Shrink()
    {
        shrinking = true;
    }

    void Update()
    {
        if (shrinking)
        {
            transform.localScale -= Vector3.one * Time.deltaTime * shrinkSpeed;
            //if (transform.localScale < targetScale)
            //    shrinking = false;
        }
    }
}
