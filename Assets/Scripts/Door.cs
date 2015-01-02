using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public float forceAmount = 300f;

	void OnMouseDown(){
		rigidbody.AddForce (-transform.forward * forceAmount, ForceMode.Acceleration);


	}


}
