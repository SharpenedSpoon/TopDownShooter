using UnityEngine;
using System.Collections;

public class CanMove : MonoBehaviour {


	public void Move(Vector3 movement) {
		transform.position += movement;
	}
}
