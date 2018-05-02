using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class Examine : MonoBehaviour
    {
        GameObject initialParent;
        Vector3 initialPosition;

        public static float DISTANCE_FROM_CAMERA = 1;
        public static float ROTATION_SPEED = 500;
        private bool isExamining = false;

        void Start()
        {
            //if (transform.parent.gameObject)
            //{
            //    initialParent = transform.parent.gameObject;
            //}
            initialPosition = transform.localPosition;
            var size = GetComponent<Collider>().bounds.size;
        }

        void Update()
        {
            if (Utilities.WasItemClicked(gameObject))
            {
                var gameManagerMaster = GameManager_References._gameManager.GetComponent<GameManager_Master>();
                gameManagerMaster.CallExamineObjectEvent(); //freezes player
                MoveToExamineZone();
                isExamining = true;
            }

            if (isExamining)
            {
                RotateObjectWithMouse();
            }

        }

        private void RotateObjectWithMouse()
        {
            float horizontal = Input.GetAxis("Mouse X");
            float vertical = Input.GetAxis("Mouse Y");
            vertical = Mathf.Clamp(vertical, -1, 1);
            var rotateFactor = ROTATION_SPEED * Time.deltaTime;
            transform.Rotate(new Vector3(vertical, horizontal, 0) * rotateFactor);
        }

        private void MoveToExamineZone()
        {
            transform.parent = GameManager_References._mainCamera.transform;
            transform.localPosition = new Vector3(0, 0, DISTANCE_FROM_CAMERA);
        }
    }
}
