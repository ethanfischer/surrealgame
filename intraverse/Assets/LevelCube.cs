using UnityEngine;
using System.Collections;

public class LevelCube : MonoBehaviour
{

	//load all the level position data into this
	public Vector3[] levelPositions;

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

	void NextLevel ()
	{
		int lc = LevelManager.GetLevelCount ();
		if (lc != null) {

			if (lc == 0) {
				SetVisibility (false);
			}

			Vector3 lp = levelPositions [lc];

			if (lp != null) {
				SetLevelCubePosition (lp);
			} else {
				Debug.Log ("lp == NULL!!!!!!!!!!!!!");
			}
		} else {
			Debug.Log ("lc == NULL!!!!!!!!!!!!");
		}

	}

	void SetVisibility (bool isVisible)
	{
		Debug.Log ("SetVisible");
		this.GetComponent<MeshRenderer> ().enabled = isVisible;
	}


}
