using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignificantItemSelector : MonoBehaviour {

	List<Transform> Items = new List<Transform>();
	GameObject ChosenItem;
    private const string PERFORM_ACTION_ON_ITEM_METHOD_NAME = "PerformActionOnItem";

	void Start () {
		SetInitialReferences();
        InvokeRepeating(PERFORM_ACTION_ON_ITEM_METHOD_NAME, 0, Pacemaker.Pace);
	}

	void SetInitialReferences()
    {
        InitializeItems();
    }

    void PerformActionOnItem()
    {
        TurnItemUpsideDown();
    }

    private void TurnItemUpsideDown()
    {
        var i = Random.Range(0, Items.Count);
        ChosenItem = Items[i].gameObject;
        ChosenItem.transform.localRotation = Quaternion.Euler(180, 0, 0);
        Debug.Log("PerformActionOnItem");
    }

    void InitializeItems()
    {
        foreach (Transform child in transform)
        {
            Items.Add(child);
        }
    }
}


