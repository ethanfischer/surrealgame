﻿using UnityEngine;

namespace Assets.Scripts
{
    public class GiveGravityOnGrab : MonoBehaviour
    {
        private Rigidbody RigidBody;
        private BoxCollider Collider; 

        // Use this for initialization
        void Start ()
        {
            RigidBody = GetComponent<Rigidbody>();
            Collider = transform.parent.GetComponent<BoxCollider>();
        }

        public void GiveGravity()
        {
            RigidBody.useGravity = true;
        }

        // Update is called once per frame
        void Update () {
		
        }
    }
}