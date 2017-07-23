using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S3
{
	public class CloseMenu : MonoBehaviour {

		void OnEnable ()
		{
			SetInitialReferences();
		}

		void OnDisable ()
		{

		}

		void SetInitialReferences()
		{

		}
		
		// Use this for initialization
		void Start () 
		{

		}
		
		// Update is called once per frame
		void Update () 
		{

		}

		public void Close()
		{
			this.gameObject.SetActive(false);
		}
	}
	
}
