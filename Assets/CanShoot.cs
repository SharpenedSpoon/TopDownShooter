using UnityEngine;
using System.Collections;

public class CanShoot : MonoBehaviour {

	public GameObject bullet;

	public void ShootAt(Vector3 direction) {
		GameObject thisBullet = Instantiate(bullet, transform.position + 1.1f*transform.forward + transform.up, transform.rotation) as GameObject;

	}

}
