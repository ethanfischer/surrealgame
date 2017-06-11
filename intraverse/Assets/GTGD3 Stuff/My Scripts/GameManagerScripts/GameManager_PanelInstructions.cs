using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S3
{
	public class GameManager_PanelInstructions : MonoBehaviour {
		public GameObject panelInstructions;
		private GameManager_Master gameManagerMaster;
		
		void OnEnable ()
		{
			SetInitialReferences();
			gameManagerMaster.GameOverEvent += TurnOffPanelInstructions;
		}

		void OnDisable ()
		{
			gameManagerMaster.GameOverEvent -= TurnOffPanelInstructions;
		}

		void SetInitialReferences()
		{
			gameManagerMaster = GetComponent<GameManager_Master>();
		}
		
		// Use this for initialization
		void Start () 
		{

		}
		
		// Update is called once per frame
		void Update () 
		{

		}

		void TurnOffPanelInstructions()
		{
			if(panelInstructions != null)
			{
				panelInstructions.SetActive(false);
			}
		}
	}
	
}
