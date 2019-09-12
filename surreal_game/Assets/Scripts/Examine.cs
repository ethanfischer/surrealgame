using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class Examine : MonoBehaviour
    {
        Transform initialParent;
        Vector3 initialPosition;
        Quaternion initialRotation;

        public static float DISTANCE_FROM_CAMERA = 1;
        public static float ROTATION_SPEED = 500;
        private bool isExamining = false;

        private Transform _item;

        GameManager_Master gameManagerMaster;

        void Start()
        {
            if (transform.parent)
            {
                initialParent = transform.parent.gameObject.transform;
            }

            gameManagerMaster = GameManager_References._gameManager.GetComponent<GameManager_Master>();
            //initialPosition = transform.localPosition;
            //initialRotation = transform.rotation;

            //SetLayerToItem();
            //AddCollider();
            //var size = GetComponent<Collider>().bounds.size;
        }

        //private void AddCollider()
        //{
        //    var collider = GetComponent<Collider>();
        //    if(collider == null)
        //    {
        //        gameObject.AddComponent<BoxCollider>();
        //    }
        //}

        //private void SetLayerToItem()
        //{
        //        gameObject.layer = LayerMask.NameToLayer("Item");
        //}

        void Update()
        {
            if (Utilities.WasItemClicked(out Transform item))
            {
                _item = item;
                ToggleExamine();
            }

            if (isExamining)
            {
                RotateObjectWithMouse();
            }
        }

        private void ToggleExamine()
        {
            if (isExamining)
            {
                PutBack();
            }
            else
            {
                PickUp();
            }
        }

        private void PickUp()
        {
            gameManagerMaster.CallExamineObjectEvent(); //freezes player
            TurnOffGravityOnItem();
            MoveToExamineZone();
            isExamining = true;
        }

        private void TurnOffGravityOnItem()
        {
            _item.GetComponent<Rigidbody>().useGravity = false;
        }

        private void RotateObjectWithMouse()
        {
            var horizontal = Input.GetAxis("Mouse X");
            var rotateFactor = ROTATION_SPEED * Time.deltaTime;
            _item.Rotate(new Vector3(0, horizontal, 0) * rotateFactor, Space.World);
        }

        private void MoveToExamineZone()
        {
            _item.parent = GameManager_References._mainCamera.transform;
            _item.localPosition = new Vector3(0, 0, DISTANCE_FROM_CAMERA);
        }

        private void PutBack()
        {
            _item.parent = initialParent;
            _item.localPosition = initialPosition;
            _item.rotation = initialRotation;

            isExamining = false;
            gameManagerMaster.CallExamineObjectEvent(); //unfreezes player
        }
    }
}
