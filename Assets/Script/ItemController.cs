using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour {

//	ItemクラスのItemtypeを型宣言
	public Item.ItemType itemType;
	public AudioClip getItemSound;
	AudioSource audioSource;
//	Inventory型 Inventoryクラスのインスタンスを生成
	Inventory inventory = new Inventory();
	GameObject key;
	// Use this for initialization
	void Start () {
//		getItemSound = Resources.Load<AudioClip>("Audio/DM-CGS-18");
//		audioSource = GetComponent<AudioSource>();
//		print (audioSource.name);
		audioSource = transform.parent.GetComponent<AudioSource>();
//		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//接触判定
	void OnTriggerEnter(Collider other){
		if (other.name == "Player") {
			audioSource.PlayOneShot (getItemSound);
			GameManager.instance.inventory.AddItem (itemType);
			inventory.AddItem (itemType);
			Destroy (gameObject);
			GameObject effectObj = gameObject.transform.parent.Find ("ItemEffect(Clone)").gameObject; 
			Destroy (effectObj);
		}
	}
}
