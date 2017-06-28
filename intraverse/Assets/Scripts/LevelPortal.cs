using UnityEngine;
using System.Collections;

namespace S3
{
	public class LevelPortal : MonoBehaviour
	{

		//load all the level position data into this
		public ArrayList adjacentNodes;
		private GameObject levelBubble;

		//public AudioSource sfx1;
		//	public Material material;
		//	private SkyboxManager skyboxManager;
		//	public SkyboxManager skyboxManager;

		//	public

		// Use this for initialization
		void Start()
		{
			SetInitialReferences();

		}

		// Update is called once per frame
		void Update()
		{

		}

		void SetInitialReferences()
		{
			GameManager_EventMaster.NextLevelEvent += NextLevel;
			levelBubble = this.transform.parent.parent.Find(this.name).gameObject;
		}

		void Reset()
		{
			//Reset the level
		}

		void SetLevelCubePosition(Vector3 lp)
		{
			this.gameObject.transform.position = lp;
		}

		Vector3 GetLevelCubePosition()
		{
			return this.gameObject.transform.position;
		}

		public void PickBubble()
		{
			//		SetVisibility (true);
			Debug.Log(gameObject);
			GameManager_Audio.PlaySFX("sfx_owl");
			//If this cube is picked, set players location to this cube.
			Player p = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
			p.SetPosition(levelBubble.transform.position); //put the player at this cube
			levelBubble.SetActive(true);
			this.transform.parent.gameObject.SetActive(false);
		}

		void NextLevel()
		{
			//		SetVisibility (false);
			//		int lc = LevelManager.GetLevelCount ();
			//		if (lc != null) {

			//		skyboxManager.SetSkyboxMaterial (material);
			//			if (lc == 0) {
			//				SetVisibility (false);
			//			}
			//
			////			Vector3 lp = levelPositions [lc];
			//
			//			if (lp != null) {
			//				SetLevelCubePosition (lp);
			//			} else {
			//				Debug.Log ("lp == NULL!!!!!!!!!!!!!");
			//			}
			//		} else {
			//			Debug.Log ("lc == NULL!!!!!!!!!!!!");
			//		}

		}

		void SetVisibility(bool isVisible)
		{
			Debug.Log("SetVisible");
			this.GetComponent<MeshRenderer>().enabled = isVisible;
		}


	}
}

