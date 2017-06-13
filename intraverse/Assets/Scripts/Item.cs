using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{

	//load all the level position data into this
	public ArrayList adjacentNodes;
	public AudioSource sfx1;
	//	public Material material;
	//	private SkyboxManager skyboxManager;
	//	public SkyboxManager skyboxManager;

	//	public

	// Use this for initialization
	void Start ()
	{
		SetInitialReferences ();

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void SetInitialReferences ()
	{
		
		GameManager_EventMaster.NextLevelEvent += NextLevel;
//		skyboxManager = GameObject.FindGameObjectWithTag ("SkyboxManager").GetComponent<SkyboxManager> ();
	}

	void Reset ()
	{
		//Reset the level
	}

	void SetLevelCubePosition (Vector3 lp)
	{
		this.gameObject.transform.position = lp;
	}

	Vector3 GetLevelCubePosition ()
	{
		return this.gameObject.transform.position;
	}

	public void PickItem ()
	{
		//Debug.Log (gameObject.name);
		sfx1.Play ();
	}

	void NextLevel ()
	{

	}

	void SetVisibility (bool isVisible)
	{
		Debug.Log ("SetVisible");
		this.GetComponent<MeshRenderer> ().enabled = isVisible;
	}


}
