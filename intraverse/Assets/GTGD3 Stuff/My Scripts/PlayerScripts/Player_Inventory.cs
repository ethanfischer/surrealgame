using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace S3
{
	public class Player_Inventory : MonoBehaviour {
		public Transform inventoryPlayerParent;
		public Transform inventoryUIParent;
		public GameObject uiButton;
		private Player_Master playerMaster;
		private GameManager_ToggleInventoryUI inventoryUIScript;
		private float timeToPlaceInHands = 0.1f;
		private Transform currentlyHeldItem;
		private int counter;
		private string buttonText;
		private List<Transform> listInventory = new List<Transform>();


		void OnEnable ()
		{
			SetInitialReferences();
			UpdateInventoryListAndUI();
			CheckIfHandsEmpty();

			playerMaster.EventInventoryChanged += UpdateInventoryListAndUI;
			playerMaster.EventInventoryChanged += CheckIfHandsEmpty;
			playerMaster.EventHandsEmpty += ClearHands;

		}

		void OnDisable ()
		{
			playerMaster.EventInventoryChanged -= UpdateInventoryListAndUI;
			playerMaster.EventInventoryChanged -= CheckIfHandsEmpty;
			playerMaster.EventHandsEmpty -= ClearHands;

		}

		void SetInitialReferences()
		{
			inventoryUIScript = GameObject.Find("GameManager").GetComponent<GameManager_ToggleInventoryUI>();
			playerMaster = GetComponent<Player_Master>();
		}
		
		// Use this for initialization
		void Start () 
		{

		}
		
		// Update is called once per frame
		void UpdateInventoryListAndUI () 
		{
			counter = 0;
			listInventory.Clear();
			listInventory.TrimExcess();

			ClearInventoryUI();

			foreach(Transform child in inventoryPlayerParent)
			{
				if(child.CompareTag("Item"))
				{
					listInventory.Add(child);
					GameObject go = Instantiate(uiButton) as GameObject;
					buttonText = child.name;
					go.GetComponentInChildren<Text>().text = buttonText;
					int index = counter;
					
					//AddListener works by assigning it a method name. But ActivateInventoryItem requires a parameter. Delegates achieves this
					go.GetComponent<Button>().onClick.AddListener(delegate
					{
						ActivateInventoryItem(index);
					});

					//When item is selected, close the menu
					go.GetComponent<Button>().onClick.AddListener(inventoryUIScript.ToggleInventoryUI);

					go.transform.SetParent(inventoryUIParent, false); //bool world position is set to false since we're dealing with a UI
					counter++;






				}
			}

		}

		void CheckIfHandsEmpty()
		{
			//Debug.Log("CheckIFHandsemp");
			if(currentlyHeldItem == null && listInventory.Count>0)
			{
				StartCoroutine(PlaceItemInHands(listInventory[listInventory.Count - 1])); //select the last item in the list
				//Debug.Log("placeiteminhands called");
			}

		}

		void ClearHands()
		{
			currentlyHeldItem = null;

		}

		void ClearInventoryUI()
		{
			foreach(Transform child in inventoryUIParent)
			{
				Destroy(child.gameObject);//clear the buttons in the inventory UI
			}

		}

		public void ActivateInventoryItem(int inventoryIndex)
		{
			DeactivateAllInventoryItems();
			StartCoroutine(PlaceItemInHands(listInventory[inventoryIndex]));

		
		}

		void DeactivateAllInventoryItems()
		{
			foreach(Transform child in inventoryPlayerParent)
			{
				if(child.CompareTag("Item"))
				{
					child.gameObject.SetActive(false);
				}
			}
		}

		IEnumerator PlaceItemInHands(Transform itemTransform) 
		{
			yield return new WaitForSeconds(timeToPlaceInHands);
			currentlyHeldItem = itemTransform;
			currentlyHeldItem.gameObject.SetActive(true);
		}
	}
	
}
