using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace S3
{

    public class RotateOverTime : MonoBehaviour
    {
        public float RotationSpeed = .1f;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (gameObject.transform.rotation.eulerAngles.y > 8.09f)
            {
                transform.Rotate(new Vector3(0, -RotationSpeed, 0));
            }
        }
    }
}
