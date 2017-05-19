using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class GameManager_EventMaster : MonoBehaviour
{

	public delegate void GeneralEvent ();

	public static event GeneralEvent NextLevelEvent;


	//	public event GeneralEvent StopPlayerMovement;
	//	public event GeneralEvent NextLevel;
	//	public event GeneralEvent DropCeiling;

	public GameObject gameOverScreen;
	//		public GameObject optionsMenu;
	//	public GameObject[] walls = new GameObject[4];
	//	public GameObject[] floorCeiling = new GameObject[2];
	//	public PaintingManager pManager;
	//	private LevelManager lManager;

	//	public GameObject gameOverAudioSource;

	//the parent gameobject that contains the walls
	//set in editor

	// // Use this for initialization
	void Start ()
	{
//		CallMyGeneralEvent ();
		SetInitialReferences ();
	}
	
	// // Update is called once per frame
	// void Update () {
	
	// }

	void SetInitialReferences ()
	{
//		lManager = GameObject.FindGameObjectWithTag ("LevelManager").GetComponent<LevelManager> ();
	}

	public void CallNextLevelEvent ()
	{
		Debug.Log ("CallNextLevelEvent");

		if (NextLevelEvent != null) {
			Debug.Log ("NextLevelEvent != null");
			NextLevelEvent ();
			// //debug.log("myGeneralEvent()");
		}
	}

	//	public void CallDropCeiling ()
	//	{
	//		if (DropCeiling != null) {
	//			DropCeiling ();
	//		}
	//
	//	}

	//	public void CallStopPlayerMovement ()
	//	{
	////			//debug.log ("CallStopPlayerMovement");
	//		if (StopPlayerMovement != null) {
	//			StopPlayerMovement ();
	////			//debug.log("stopPlayerMovement()");
	//		}
	//	}

	public void GameOver ()
	{

		if (gameOverScreen != null) {
			gameOverScreen.SetActive (true); 				//Display the gameover screen

//			gameOverAudioSource.GetComponent<AudioSource> ().Play ();
//				optionsMenu.SetActive (true);
//			SetWallsFloorCeiling (false); //deactivate wallsfloorcieling



		} else {
			Debug.Log ("No game over screen found!");
		}


	}


	//
	//	void SetWallsFloorCeiling (bool active)
	//	{
	//		//Activate or deactivate walls
	//		if (walls.Length > 0) {
	//			foreach (GameObject wall in walls) {
	////					wall.Reset ();	
	//				wall.SetActive (active); //make walls invisible (only for gameoverscreen)
	//			}
	//		} else {
	//			Debug.Log ("GameOver(): No walls to deactivate");
	//		}
	//
	//		//Activate or deactivate floor and ceiling
	//		if (floorCeiling.Length > 0)
	//			foreach (GameObject fc in floorCeiling) {
	//				fc.SetActive (active);
	//			}
	//		else {
	//			Debug.Log ("GameOver(): No floor or ceiling to deactivate");
	//		}
	//	}

	void ExitGameOverScreen ()
	{
		if (gameOverScreen != null) {
			gameOverScreen.SetActive (false); 				//Display the gameover screen
//			SetWallsFloorCeiling (true);
		}
	}



	public void Reset ()
	{
		Debug.Log ("Reset()");

//			int scene = SceneManager.GetActiveScene ().buildIndex;
//			SceneManager.LoadScene (scene, LoadSceneMode.Single);

//		lManager.NextLevel ();
//			Debug.Log ("pManager.ResetPaintings" + pManager);
		ExitGameOverScreen ();
//			ResetZoom ();

	}

	public void ResetZoom ()
	{
		GameObject mCamera = GameObject.FindGameObjectWithTag ("MainCamera");
		StereoController sCon = mCamera.GetComponent<StereoController> ();
		sCon.matchMonoFOV = 0;
	}


}


