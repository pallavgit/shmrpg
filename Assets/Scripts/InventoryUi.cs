using UnityEngine;

public class InventoryUi : MonoBehaviour {

	Inventory inventory;


	// Use this for initialization
	void Start () {
		inventory = Inventory.instance;
		inventory.onItemChangedCallback += UpdateUI;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void UpdateUI ()  
	{
		Debug.Log ("UpdateUI");
		
	}

}
