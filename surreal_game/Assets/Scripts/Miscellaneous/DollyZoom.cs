//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//namespace SurrealGame
//{

//    public class DollyZoom : MonoBehaviour
//    {

//        public const float ObjectSize = 1f;
//        public const float PictureSize = 4f;
//        public float DistanceFromObject;
//        public GameObject target;
//        // Use this for initialization
//        void Start()
//        {


//        }

//        // Update is called once per frame
//        void Update()
//        {
//            UpdateCameraFOV();

//        }

//        void UpdateCameraFOV()
//        {
//            GetComponent<Camera>().fieldOfView = CalculateFOV();
//        }

//        float CalculateFOV()
//        {
//            DistanceFromObject = Vector3.Distance(target.transform.position, transform.position);
//            var fov = (float)(2f * (Math.Atan((ObjectSize * PictureSize) / 2f * DistanceFromObject)));
//            return fov;

//        }
//    }
//}

using UnityEngine;
using System.Collections;

public class DollyZoom : MonoBehaviour
{
    public Transform target;
    public Camera camera;

    private float initHeightAtDist;
    private bool dzEnabled;

    // Calculate the frustum height at a given distance from the camera.
    float FrustumHeightAtDistance(float distance)
    {
        return 2.0f * distance * Mathf.Tan(camera.fieldOfView * 0.5f * Mathf.Deg2Rad);
    }

    // Calculate the FOV needed to get a given frustum height at a given distance.
    float FOVForHeightAndDistance(float height, float distance)
    {
        return 2.0f * Mathf.Atan(height * 0.5f / distance) * Mathf.Rad2Deg;
    }

    // Start the dolly zoom effect.
    void StartDZ()
    {
        var distance = Vector3.Distance(transform.position, target.position);
        initHeightAtDist = FrustumHeightAtDistance(distance);
        dzEnabled = true;
    }

    // Turn dolly zoom off.
    void StopDZ()
    {
        dzEnabled = false;
    }

    void Start()
    {
        StartDZ();
    }

    void Update()
    {
        if (dzEnabled)
        {
            // Measure the new distance and readjust the FOV accordingly.
            var currDistance = Vector3.Distance(transform.position, target.position);
            camera.fieldOfView = FOVForHeightAndDistance(initHeightAtDist, currDistance);
        }

        // Simple control to allow the camera to be moved in and out using the up/down arrows.
        transform.Translate(Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime * 5f);
    }
}
