using UnityEngine;
using System.Collections;

public class TreasureChest : MonoBehaviour {

	Animator anim;
	bool isOpen = false;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//接触判定
	void OnTriggerEnter(Collider other){
		if (other.name == "Player" && isOpen == false) {
			anim.SetBool ("IsOpen", true);
			GameObject effectObj = Resources.Load<GameObject> ("Effects/ItemEffect");
			//Instantiate (effectObj,gameObject.transform.position,effectObj.transform.rotation);
			GameObject effect = (GameObject)Instantiate(effectObj, gameObject.transform.position, effectObj.transform.rotation);
			effect.transform.parent = gameObject.transform; 
			isOpen = true;
		}
	}
}
