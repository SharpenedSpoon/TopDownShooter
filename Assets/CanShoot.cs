using UnityEngine;
using System.Collections;

public class CanShoot : MonoBehaviour {

	public GameObject bullet;

	private float nextShotTime = 0.0f;
	private IsBullet bulletProperties = null;
	private bool useRateOfFire = false;

	void Awake () {
		bulletProperties = bullet.GetComponent<IsBullet>();
		if (bulletProperties != null) {
			useRateOfFire = bulletProperties.useRateOfFire;
		}
	}

	public void ShootAt(Vector3 direction) {
		if (!useRateOfFire || (Time.time >= nextShotTime)) {
			GameObject thisBullet = Instantiate(bullet, transform.position + 1.1f*transform.forward + transform.up, transform.rotation) as GameObject;
			if (useRateOfFire) {
				nextShotTime = Time.time + bulletProperties.rateOfFire;
			}
		}
	}

}
