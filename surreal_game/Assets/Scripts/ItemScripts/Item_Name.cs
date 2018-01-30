using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
	public class Item_Name : MonoBehaviour {
		public string itemName;

		void Start ()
		{
			SetItemName();
		}

		void SetItemName()
		{
			transform.name = itemName;

		}

		
	}
	
}
