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
			//GameManager_EventMaster.NextLevelEvent += NextLevel;
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
			if (!CheckIfLocked())
			{
				Debug.Log("picking: " + gameObject);
				GameManager_Audio.PlaySFX("sfx_owl");
				//If this cube is picked, set players location to this cube.
				Player p = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
				p.SetPosition(levelBubble.transform.position); //put the player at this cube
				levelBubble.SetActive(true);
				this.transform.parent.gameObject.SetActive(false);
			}

		}

		bool CheckIfLocked()
		{
			foreach (Transform child in gameObject.transform)
			{
				//Debug.Log(gameObject.name + " has children");
				if (child.gameObject.CompareTag("Lock"))
				{
					if (child.gameObject.activeInHierarchy)
					{
						//Debug.Log(this.name + " has a lock");
						//attempt to lock any locked items (Item Lock checks if player has the key)
						if (child.GetComponent<Item_Lock>().Unlock())
						{
							this.GetComponent<MeshRenderer>().enabled = true; //show the LevelPortal once you unlock it
							return false; //We want to carry out the pickup action simultaneously with the items being unlocked. 
						}
						return true;
					}
					//Debug.Log(child.name + "a in h: " + child.gameObject.activeInHierarchy);
				}
				//Debug.Log(gameObject.name + " child doesn't have Lock tag");
			}
			return false;
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

