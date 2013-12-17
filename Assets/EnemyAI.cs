using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public float movementSpeed = 2.0f;

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(player.transform.position);
		transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
	}
}
