using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehavior : MonoBehaviour {

	public Vector3 enemyPosition;
	public bool moveBullet = false;
	public float projectileSpeed = 0.5f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//print (enemyPosition - transform.position);
		//transform.position = transform.position + new Vector3 (Time.deltaTime * move_rate_x,Time.deltaTime * move_rate_y,0);
		//Vector3 direction = enemyPosition - transform.position;
		//transform.position = Vector3.Lerp(transform.position, enemyPosition, 0.05f);
		if (moveBullet){
			targetBullet ();
		}


		if (transform.position == enemyPosition){
			Destroy(gameObject);
		}

	}

	public void targetBullet(){
		Rigidbody rb = gameObject.GetComponent<Rigidbody>();
		Vector3 pos = Vector3.MoveTowards(transform.position, enemyPosition, projectileSpeed * Time.deltaTime);
		moveBullet = true;
		rb.MovePosition(pos);
	}


}
