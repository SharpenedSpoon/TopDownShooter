using UnityEngine;
using System.Collections;

public class CanRotate : MonoBehaviour {

	public void RotateTowards(Vector3 targetPosition) {
		transform.LookAt(targetPosition);
	}

}
