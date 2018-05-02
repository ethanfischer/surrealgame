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

        private static float DISTANCE_FROM_CAMERA = 1;

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
                gameManagerMaster.CallExamineObjectEvent();
                MoveToExamineZone();
            }

        }

        private void MoveToExamineZone()
        {
            transform.parent = GameManager_References._mainCamera.transform;
            transform.localPosition = new Vector3(0, 0, DISTANCE_FROM_CAMERA);
        }
    }
}
