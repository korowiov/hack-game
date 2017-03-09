using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createTower : MonoBehaviour {

	public GameObject towerDefence;
	bool hasTower = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		print ("asd");
		if (!hasTower) {
			towerDefence.transform.position = transform.position;
			Instantiate (towerDefence);
			hasTower = true;
		}
	}
}
