using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

	public GameObject enemy;
	public int numberOfEnemies;


	void Start() {
		InvokeRepeating("spawnEnemy", 1.0f,1.0f);
	}

	void spawnEnemy() {
		numberOfEnemies--;
		Instantiate (enemy);
		if (numberOfEnemies <= 0)
			CancelInvoke ();
	}
}
