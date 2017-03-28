using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour {

	Rigidbody2D player;

	public float moveSpeed;
	public float jumpHeight;

	public bool canMove;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (!canMove) {
			return;
		}

		if (Input.GetKey (KeyCode.A))
			Move (-0.2f, 0);
		if (Input.GetKey (KeyCode.D))
			Move (0.2f, 0);
		if (Input.GetKeyDown (KeyCode.W)) {
			
			player.AddForce (new Vector2(0, jumpHeight), ForceMode2D.Impulse);

		}
	}

	//void OnCollisionEnter2D (Collision2D other) {

		//if (other.gameObject.tag == "killbox") {

		//}
	//}


	
		
	void Move (float x, float y) {
		Vector3 pos = transform.position;
		pos.x += x;
		pos.y += y;
		transform.position = pos;
	}
}
