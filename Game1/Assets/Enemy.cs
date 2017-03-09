using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float move_rate_x, move_rate_y;
	public int health = 1;

	public void setMoveRate(float x = 0, float y = 0) {
		move_rate_x = x;
		move_rate_y = y;
	}

	void Update () {
		transform.position = transform.position + new Vector3 (Time.deltaTime * move_rate_x,Time.deltaTime * move_rate_y,0);
	}

	void OnTriggerEnter(Collider collider) {
		print (collider.name);
		if (collider.CompareTag("bullet_enemy")){
			health--;
			if (health <= 0) {
				Destroy (gameObject);
			}
		}
	}
}
