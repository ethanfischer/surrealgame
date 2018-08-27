using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class HideHand : MonoBehaviour {
    public VRTK_AvatarHandController handController;
    public SkinnedMeshRenderer VRTK_BasicHand;

	// Use this for initialization
	void Start () {
        if(handController == null)
        {
            Debug.LogError("Missing handController in HideHands script");
        }
        if(VRTK_BasicHand == null)
        {
            Debug.LogError("Missing VRTK_BasicHand in HideHands script");
        }
		
	}
	
	// Update is called once per frame
	void Update () {
        if(handController.interactGrab.IsGrabButtonPressed())
        {
            Debug.Log("hide hands");
            VRTK_BasicHand.enabled = false;
        }
        else
        {
            VRTK_BasicHand.enabled = true;
        }
		
	}
}
