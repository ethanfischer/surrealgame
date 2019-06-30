using Assets.Scripts.PlayerScripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using VRTK;

namespace Assets.Scripts.PlayerScripts
{


    public class Player_Stash_Item : MonoBehaviour
    {

        private IPlayerInventory Inventory { get; set; }
        //public VRTK_AvatarHandController Right_VRTK_AvatarHandController;
        //public VRTK_AvatarHandController Left_VRTK_AvatarHandController;

        // Use this for initialization
        void Start()
        {
            SetInitialReferences(); //TODO figure out way to make this more like a constructor

            if (Inventory == null) Debug.LogError("Inventory is null");

            throw new NotImplementedException();
            //if (Right_VRTK_AvatarHandController == null) Debug.LogError("Right_VRTK_AvatarHandController  is null");
            //if (Left_VRTK_AvatarHandController == null) Debug.LogError("Left_VRTK_AvatarHandController is null");

            //Left_VRTK_AvatarHandController.interactUse.ControllerStartUseInteractableObject += StashItem;
            //Right_VRTK_AvatarHandController.interactUse.ControllerStartUseInteractableObject += StashItem;
        }

        private void SetInitialReferences()
        {
            Inventory = GetComponentInChildren<IPlayerInventory>();
        }

        // Update is called once per frame
        void Update()
        {


        }

        //void StashItem(object o, ObjectInteractEventArgs e)
        //{
        //    var target = e.target;
        //    Inventory.Add(target);
        //}
    }
}
