using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Miscellaneous;
using SurrealGame;
using UnityEngine;

public class SignificantItemSelector : MonoBehaviour
{
    private GameObject Collectables;
	List<Transform> Items = new List<Transform>();
	GameObject ChosenItem;
    private const string PERFORM_ACTION_ON_ITEM_METHOD_NAME = "PerformActionOnItem";
    private Pacemaker Pacemaker;

	void Start () {
		SetInitialReferences();
        Pacemaker.OnHeartbeat += PerformActionOnItem;
    }

	void SetInitialReferences()
	{
	    Collectables = GameObject.FindGameObjectWithTag(Tags.COLLECTABLES);
        if(Collectables  == null) Debug.LogError("Collectables  null");

        InitializeItems();
        Pacemaker = Pacemaker.Instance;
    }

    void PerformActionOnItem(object sender, HeartbeatEventArgs e)
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
        foreach (Transform child in Collectables.transform)
        {
            Items.Add(child);
        }
    }
}


