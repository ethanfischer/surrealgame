using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlyAffectItem : MonoBehaviour {

	List<Transform> Items = new List<Transform>();
	GameObject ChosenItem;

	void Start () {
		SetInitialReferences();
		StartCoroutine(AffectItem());
	}

	void SetInitialReferences()
    {
        InitializeItems();
    }

    IEnumerator AffectItem()
    {
        Debug.Log("1");
        yield return new WaitForSeconds(HeartBeat.Pace);

        Debug.Log("2");
        TurnItemUpsidedDown();
    }

    void TurnItemUpsidedDown()
    {
        var i = Random.Range(0, Items.Count);
        ChosenItem = Items[i].gameObject;
        ChosenItem.transform.localRotation = Quaternion.Euler(180, 0, 0);
        Debug.Log("AffectItem");
    }

    void InitializeItems()
    {
        foreach (Transform child in transform)
        {
            Items.Add(child);
        }
    }
}
