﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S3
{
	public class Player_DetectItem : MonoBehaviour {
		[Tooltip("What layer is being used for items")]
		public LayerMask layerToDetect;
		[Tooltip("What transform will the ray be fired from?")]
		public Transform rayTransformPivot;
		[Tooltip("The editor input button that will be used for picking up items")]
		public string buttonPickup;

        public Transform inventory;

		private Transform itemAvailableForPickup;
		private RaycastHit hit;
		private float detectRange = 3f;
		private float detectRadius = 0.7f;
		private bool itemInRange;

		private float labelWidth = 200;
		private float labelHeight = 50;

		// Update is called once per frame
		void Update () 
		{
			CastRayForDetectingItems();
			CheckItemForPickupAttempt();
		}

		void CastRayForDetectingItems()
		{
			if(Physics.SphereCast(rayTransformPivot.position, detectRadius, rayTransformPivot.forward, out hit, detectRange, layerToDetect))
			{
				itemAvailableForPickup = hit.transform;
				itemInRange = true;
			}
			else
			{
				itemInRange = false;
			}
		}

		
		void CheckItemForPickupAttempt()
		{
			if(Input.GetButtonDown(buttonPickup) && Time.timeScale > 0 && itemInRange && itemAvailableForPickup.root.tag != GameManager_References._playerTag)
			{
				Debug.Log("Pickup Attempted");
				itemAvailableForPickup.GetComponent<Item_Master>().CallEventPickupAction(inventory);
			}

		}

		void OnGUI()
		{
			if(itemInRange && itemAvailableForPickup != null)
			{
				//GUI.Label(new Rect(Screen.width / 2 - labelWidth/2, Screen.height / 2, labelWidth, labelHeight), itemAvailableForPickup.name);
			}
		}
	}
	
}
