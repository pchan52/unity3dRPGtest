using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	//Listの宣言
	List<int> itemList = new List<int>();

	public void AddItem(Item.ItemType type){
		Debug.Log ((int)type);
		itemList.Add ((int)type);
	}

	public bool HasItem(){
		if (itemList.Count >= 1) {
			return true;
		} else {
			return false;
		}
		
	}
}
