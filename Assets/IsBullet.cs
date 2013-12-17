using UnityEngine;
using System.Collections;

public class IsBullet : MonoBehaviour {

	public float speed = 20.0f;

	public float lifetime = 30.0f;

	private float birthTime;
	private float deathTime;


	// Use this for initialization
	void Start () {
		rigidbody.velocity = speed * transform.forward;
		birthTime = Time.time;
		deathTime = birthTime + lifetime;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= deathTime) {
			Destroy(gameObject);
		}
	}
}
