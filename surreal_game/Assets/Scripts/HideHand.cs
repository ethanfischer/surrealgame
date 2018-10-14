using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class HideHand : MonoBehaviour
{
    public VRTK_AvatarHandController handController;
    public SkinnedMeshRenderer VRTK_BasicHand;

    // Use this for initialization
    void Start()
    {
        if (handController == null)
        {
            Debug.LogError("Missing handController in HideHands script");
        }
        if (VRTK_BasicHand == null)
        {
            Debug.LogError("Missing VRTK_BasicHand in HideHands script");
        }

        handController.interactGrab.ControllerStartGrabInteractableObject += Hide;
        handController.interactGrab.ControllerStartUngrabInteractableObject += Show;

    }

    void Hide(object sender, ObjectInteractEventArgs e)
    {
        VRTK_BasicHand.enabled = false;
    }

    void Show(object sender, ObjectInteractEventArgs e)
    {
        VRTK_BasicHand.enabled = true;
    }
}
