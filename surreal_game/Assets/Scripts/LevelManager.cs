using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
	static int levelCount;

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
		SetLevelCount (0); //Start at level 0 (Main Menu)
//		GameManager_EventMaster.NextLevelEvent += IncrementLevelCount;//Subscribe to NextLevelEvent
	}

	public static int GetLevelCount ()
	{
		return levelCount;
	}

	public void SetLevelCount (int i)
	{
		//Debug.Log ("SetLevelCount()");
		levelCount = i;
	}

	public void IncrementLevelCount ()
	{
		Debug.Log ("IncrementLevelCount()");
		levelCount++;
	}


}
