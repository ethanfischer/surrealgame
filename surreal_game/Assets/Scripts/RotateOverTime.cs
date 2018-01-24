using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S3
{

    public class RotateOverTime : MonoBehaviour
    {
        public float RotationSpeed = .1f;
        public bool Oscilate = true;
        public float ClockwiseLimit = 8.09f;
        public float CounterClockwiseLimit = 8.0f;
        private bool RotateBack;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (gameObject.transform.rotation.eulerAngles.y > ClockwiseLimit && !RotateBack)
            {
                transform.Rotate(new Vector3(0, -RotationSpeed, 0));
            }
            else if (gameObject.transform.rotation.eulerAngles.y < CounterClockwiseLimit)
            {
                RotateBack = true;
                transform.Rotate(new Vector3(0, RotationSpeed, 0));
            }
            else
            {
                RotateBack = false;
            }
            //if (gameObject.transform.rotation.eulerAngles.y > CounterClockwiseLimit)
            //{
            //    transform.Rotate(new Vector3(0, -RotationSpeed, 0));
            //}
            //else if (gameObject.transform.rotation.eulerAngles.y < ClockwiseLimit)
            //{
            //    //transform.Rotate(new Vector3(0, -RotationSpeed, 0));
            //}
        }

        void IsOverClockWiseLimit()
        {

        }
    }
}
