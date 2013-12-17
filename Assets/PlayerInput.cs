using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CanMove))]
[RequireComponent (typeof (CanShoot))]
[RequireComponent (typeof (CanRotate))]
public class PlayerInput : MonoBehaviour {

	private CanMove mover = null;
	private CanShoot shooter = null;
	private CanRotate rotater = null;

	private Camera camera; 

	public float movementSpeed = 5.0f;

	private RaycastHit hit;

	void Start () {
		mover = GetComponent<CanMove>();
		shooter = GetComponent<CanShoot>();
		rotater = GetComponent<CanRotate>();

		camera = Camera.main;
	}

	void FixedUpdate () {
		GetMovement();
		LookAtMouse();
		GetShooting();


		camera.transform.position = transform.position + new Vector3(0.0f, 15.0f, -10.0f);
	}

	private void GetMovement() {
		float hor = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
		float ver = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
		
		Vector3 movement = new Vector3(hor, 0.0f, ver);
		mover.Move(movement);
	}

	private void LookAtMouse() {
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100.0f)) {
			Vector3 targetPoint = hit.point;
			targetPoint.y = transform.position.y; // always look parallel to plane
			rotater.RotateTowards(targetPoint);
		}
	}

	private void GetShooting() {
		if (Input.GetButton("Fire1")) {
			shooter.ShootAt(transform.forward);
		}
	}
}
