using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {
	Animation anim;
	BoxCollider boxCollider;
	public int hp = 100;
	public Image hpGauge;
	int fullHp;
	int attackPower;
	GameObject hpObj;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
		boxCollider = GetComponent<BoxCollider> ();
		hpObj = transform.Find ("HP").gameObject;
		fullHp = hp;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "cutter01") {
			attackPower = other.GetComponent<Weapon> ().power;
			hp -= attackPower;
			hpGauge.fillAmount = (float)hp / fullHp;
			print (hp);
			if (hp <= 0) {
				anim.Play ("Allosaurus_Die");
				Destroy (boxCollider);
				Destroy (hpObj);
			}
		}
	}
}
