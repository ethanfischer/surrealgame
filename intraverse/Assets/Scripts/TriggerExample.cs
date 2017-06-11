using UnityEngine;
using System.Collections;


public class TriggerExample : MonoBehaviour
{

	private GameManager_EventMaster eventMasterScript;

	void Start ()
	{
		SetInitialReferences ();
	}


	void OnTriggerEnter (Collider other)
	{
//	   eventMasterScript.CallMyGeneralEvent();
		if (eventMasterScript != null && other.CompareTag ("Player")) {

//				Debug.Log ("player collided");
			
			eventMasterScript.GameOver ();

		}
//	   DestroyObject(gameObject);
	}

	void OnButtonClicked ()
	{
		if (eventMasterScript != null) {
			eventMasterScript.CallNextLevelEvent ();
		}
	}

    
	void SetInitialReferences ()
	{
		eventMasterScript = GameObject.Find ("GameManager").GetComponent<GameManager_EventMaster> ();
	}
}


