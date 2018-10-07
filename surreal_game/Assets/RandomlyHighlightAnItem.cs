using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlyHighlightAnItem : MonoBehaviour {

	List<Transform> Items = new List<Transform>();
	GameObject ChosenItem;

	void Start () {
		SetInitialReferences();
		InvokeRepeating("TurnUpsideDown", 5, 5);
	}

	void SetInitialReferences()
	{
		foreach(Transform child in transform)
		{
			Items.Add(child);
		}
	}

    void TurnUpsideDown()
	{
		var i = Random.Range(0, Items.Count);
        ChosenItem = Items[i].gameObject;
        ChosenItem.transform.localRotation = Quaternion.Euler(180, 0, 0);
	}
}


