using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SurrealGame
{

    public class MoveOverTime : MonoBehaviour
    {
        public float CreepSpeed = .1f;
        public float MaxX = -50f;
        public float MaxZ = -5f;


        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (gameObject.transform.position.x < MaxX)
            {
                transform.Translate(Vector3.right * CreepSpeed, Space.World);
            }
            //if (gameObject.transform.position.z > MaxZ)
            //{
            //    transform.Translate(Vector3.back * CreepSpeed/10, Space.World);
            //}
            if(CreepSpeed > .09) CreepSpeed -= Time.time/100000;
        }
    }
}
