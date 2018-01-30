using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
	public class Item_Tag : MonoBehaviour {
		public string itemTag;

		void OnEnable ()
		{
			SetTag();
		}

		void SetTag()
		{
			if(itemTag == "")
			{
				itemTag = "Untagged";
			}
			transform.tag = itemTag;

		}
	
	}
	
}
