using UnityEngine;
using System.Collections;

public class autoDoor : MonoBehaviour {

	Animator anim;

	public bool conditionNeedItem = false;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other) {
		if (other.name == "Player") {
			if (conditionNeedItem == false) {
				anim.SetBool ("IsOpen", true);
			} else {
				if (GameManager.instance.inventory.HasItem ()) {
					anim.SetBool ("IsOpen", true);
				}
			}
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.name == "Player") {
			anim.SetBool ("IsOpen", false);
		}
	}
}