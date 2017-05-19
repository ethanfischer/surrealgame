using UnityEngine;
using System.Collections;

public class SkyboxManager : MonoBehaviour
{
	public Camera cameraRight;
	public Camera cameraLeft;
	private Skybox skyboxRight;
	private Skybox skyboxLeft;
	//	private GameManager_EventMaster eventMasterScript; no longer needed because events are static :)

	public Material[] materials;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void SetInitialReferences ()
	{
//		eventMasterScript = GameObject.Find ("GameManager").GetComponent<GameManager_EventMaster> (); no longer needed because events are static
		GameManager_EventMaster.NextLevelEvent += NextLevel; //Subcribe NextLevel() to the NextLevelEvent

	}

	void NextLevel ()
	{
		Material m = GetSkyboxMaterial (0);
		SetSkyboxMaterial (m);
	}


	void SetSkyboxMaterial (Material m)
	{
		// Get each skybox
		if (cameraRight != null && cameraLeft != null) {
			skyboxRight = cameraRight.GetComponent<Skybox> ();
			skyboxLeft = cameraLeft.GetComponent<Skybox> ();
		}

		// set skyboxes' material
		skyboxRight.material = m;
		skyboxLeft.material = m;
	}

	//	Material GetRandomSkyboxMaterial ()
	//	{
	//		//TODO
	//		// 1. Given an array of Materials, pick one that has not been shown and return it
	//		Material m =
	//	}

	Material GetSkyboxMaterial (int i)
	{
		Debug.Log (materials [i].name);
		return materials [i];
	}
}
