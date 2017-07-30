using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCar : MonoBehaviour {

	Vector3 startPos;
	Quaternion startRot;
	public float radius = 100.0F;
	public float power = 10000000.0F;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
		startRot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
			transform.position = startPos;
			transform.rotation = startRot;
		}

		if (Input.GetKeyDown (KeyCode.B)) {
			Debug.Log ("BLOW UP");
			Vector3 explosionPos = transform.position;

			rb.AddExplosionForce (power, explosionPos, radius, 1);

			//rb.AddForce(transform.up * power);
			//transform.Translate(new Vector3(0, 10, 0));
		}
	}
}
