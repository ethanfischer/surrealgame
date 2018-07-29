﻿using System;
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

        GameManager_Master gameManagerMaster;

        void Start()
        {
            if (transform.parent)
            {
                initialParent = transform.parent.gameObject.transform;
            }

            gameManagerMaster = GameManager_References._gameManager.GetComponent<GameManager_Master>();
            initialPosition = transform.localPosition;
            initialRotation = transform.rotation;

            SetLayerToItem();
            AddCollider();
            var size = GetComponent<Collider>().bounds.size;

        }

        private void AddCollider()
        {
            var collider = GetComponent<Collider>();
            if(collider == null)
            {
                gameObject.AddComponent<BoxCollider>();
            }
        }

        private void SetLayerToItem()
        {
                gameObject.layer = LayerMask.NameToLayer("Item");
        }

        void Update()
        {
            if (Utilities.WasItemClicked(gameObject))
            {
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
            MoveToExamineZone();
            isExamining = true;
        }

        private void RotateObjectWithMouse()
        {
            var horizontal = Input.GetAxis("Mouse X");
            var rotateFactor = ROTATION_SPEED * Time.deltaTime;
            transform.Rotate(new Vector3(0, horizontal, 0) * rotateFactor, Space.World);
        }

        private void MoveToExamineZone()
        {
            transform.parent = GameManager_References._mainCamera.transform;
            transform.localPosition = new Vector3(0, 0, DISTANCE_FROM_CAMERA);
        }

        private void PutBack()
        {
            transform.parent = initialParent;
            transform.localPosition = initialPosition;
            transform.rotation = initialRotation;

            isExamining = false;
            gameManagerMaster.CallExamineObjectEvent(); //unfreezes player
        }
    }
}
