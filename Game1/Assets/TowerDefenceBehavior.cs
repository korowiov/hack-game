using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDefenceBehavior : MonoBehaviour {

	public GameObject bullet;
	private Vector3 enemyPosition;
	private bool enemyExists = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void shootBullet(){
		if(enemyExists) {
			bullet.transform.position = transform.position;
			GameObject currentBullet = Instantiate (bullet);
			currentBullet.GetComponent<bulletBehavior>().enemyPosition = enemyPosition;
			currentBullet.GetComponent<bulletBehavior> ().targetBullet ();
		}
	}

	void OnTriggerStay(Collider collider) {
		enemyPosition = collider.gameObject.transform.position;
		if (!enemyExists) {
			
			enemyExists = true;
			InvokeRepeating("shootBullet", 0.0f,1.0f);
		}
	}
}
