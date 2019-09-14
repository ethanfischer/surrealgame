using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class Examine : MonoBehaviour
    {
        //Transform initialParent;
        //Vector3 initialPosition;
        //Quaternion initialRotation;

        public static float DISTANCE_FROM_CAMERA = 1;
        public static float ROTATION_SPEED = 500;
        private bool isExamining = false;

        private GameObject _item;
        private GameObject _itemCopy;

        GameManager_Master gameManagerMaster;

        void Start()
        {
            //if (transform.parent)
            //{
            //    initialParent = transform.parent.gameObject.transform;
            //}

            gameManagerMaster = GameManager_References._gameManager.GetComponent<GameManager_Master>();
            //initialPosition = transform.localPosition;
            //initialRotation = transform.rotation;

            //SetLayerToItem();
            //AddCollider();
            //var size = GetComponent<Collider>().bounds.size;
        }

        void Update()
        {
            if (isExamining)
            {
                if(Utilities.DidClick())
                {
                    PutBack();
                }

                RotateObjectWithMouse();
            }
            else if (Utilities.WasItemClicked(out Transform item))
            {
                _item = item.gameObject;
                _itemCopy = GameObject.Instantiate(item.gameObject);
                PickUp();
            }
        }

        private void PickUp()
        {
            _item.SetActive(false);
            gameManagerMaster.CallExamineObjectEvent(); //freezes player
            TurnOffGravityOnItem();
            TurnOffCollider();
            MoveToExamineZone();
            isExamining = true;
        }

        private void TurnOffCollider()
        {
            var collider = _itemCopy.GetComponentInChildren<Collider>();
            if(collider != null)
            {
                collider.enabled = false;
            }
        }

        private void TurnOffGravityOnItem()
        {
            var rigidBody = _itemCopy.GetComponent<Rigidbody>();
            rigidBody.useGravity = false;
            rigidBody.constraints = RigidbodyConstraints.FreezeAll;
        }

        private void RotateObjectWithMouse()
        {
            var horizontal = Input.GetAxis("Mouse X");
            var rotateFactor = ROTATION_SPEED * Time.deltaTime;
            _itemCopy.transform.Rotate(new Vector3(0, horizontal, 0) * rotateFactor, Space.World);
        }

        private void MoveToExamineZone()
        {
            _itemCopy.transform.parent = GameManager_References._mainCamera.transform;
            _itemCopy.transform.localPosition = new Vector3(0, 0, DISTANCE_FROM_CAMERA);
        }

        private void PutBack()
        {
            GameObject.Destroy(_itemCopy.gameObject);
            _item.gameObject.SetActive(true);
            isExamining = false;
            gameManagerMaster.CallExamineObjectEvent(); //unfreezes player
        }
    }
}
