using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

	public int health = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter(Collision collision) {
		Debug.Log("col");
		health = health - 1;
		print (collision.collider.name);
		print (gameObject.name);
		GameObject enemy = GameObject.Find (collision.collider.name);
		Destroy (enemy);
		if (health <= 0) {
			Destroy (gameObject);
		}
	}
}
