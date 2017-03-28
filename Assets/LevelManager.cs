using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject currentRespawn;

	private WASD player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<WASD> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RespawnPlayer() {

		Debug.Log ("Player Respawn");
		player.transform.position = currentRespawn.transform.position;

	}
}
