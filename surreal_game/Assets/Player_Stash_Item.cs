using Assets.Scripts.PlayerScripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Player_Stash_Item : MonoBehaviour
{

    private IPlayerInventoryVR InventoryGameObject { get; set; }
    public VRTK_AvatarHandController VRTK_AvatarHandController;

    // Use this for initialization
    void Start()
    {
        SetInitialReferences(); //TODO figure out way to make this more like a constructor

        if (InventoryGameObject == null) Debug.LogError("InventoryGameObject is null");
        if (VRTK_AvatarHandController == null) Debug.LogError("VRTK_ControllerEvents is null");

        VRTK_AvatarHandController.interactUse.ControllerStartUseInteractableObject += StashItem;
    }

    private void SetInitialReferences()
    {
        InventoryGameObject = GetComponent<IPlayerInventoryVR>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void StashItem(object o, ObjectInteractEventArgs e)
    {
        var target = e.target;
        Debug.Log("target " + target);
    }
}
