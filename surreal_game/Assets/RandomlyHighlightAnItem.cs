using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlyHighlightAnItem : MonoBehaviour {

	List<Transform> Items = new List<Transform>();
	GameObject ChosenItem;

	void Start () {
		SetInitialReferences();
		StartCoroutine(TurnUpsideDown());
	}

	void SetInitialReferences()
	{
		foreach(Transform child in transform)
		{
			Items.Add(child);
		}
	}

    IEnumerator TurnUpsideDown()
	{
		yield return new WaitForSeconds(5);
		var i = Random.Range(0, Items.Count);
        ChosenItem = Items[i].gameObject;
        ChosenItem.transform.localRotation = Quaternion.Euler(180, 0, 0);
		Debug.Log("TurnUpsideDown");
	}
}


