using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoute : MonoBehaviour {

	public float setMoveX = 1.0f;
	public float setMoveY = 1.0f;

	void OnCollisionEnter(Collision collision) {
		Enemy enemy = collision.collider.gameObject.GetComponent<Enemy>();
		enemy.setMoveRate (setMoveX, setMoveY);
	}
}
