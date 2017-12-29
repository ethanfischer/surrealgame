using UnityEngine;
using System.Collections;

namespace S3
{
    public class TriggerExample : MonoBehaviour
    {

        private GameManager_EventMaster eventMasterScript;

        void Start()
        {
            SetInitialReferences();
        }


        void OnTriggerEnter(Collider other)
        {
            //	   eventMasterScript.CallMyGeneralEvent();
            if (eventMasterScript != null && other.CompareTag("Player"))
            {
                //				Debug.Log ("player collided");
            }
            //	   DestroyObject(gameObject);
        }

        void OnButtonClicked()
        {
            if (eventMasterScript != null)
            {
            }
        }


        void SetInitialReferences()
        {
            eventMasterScript = GameObject.Find("GameManager").GetComponent<GameManager_EventMaster>();
        }
    }
}

