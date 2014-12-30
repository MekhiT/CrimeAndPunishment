using UnityEngine;
using System.Collections;


public class CharControlMove : MonoBehaviour {

	public float MoveSpeed;
	public float RotationSpeed;
	CharacterController cc;
	// Use this for initialization
	void Start () {

		cc = GetComponent<CharacterController> ();

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 movePos = Input.GetAxis ("Vertical") * transform.TransformDirection (Vector3.forward) * MoveSpeed;
		transform.Rotate (new Vector3(0, Input.GetAxis ("Horizontal") * RotationSpeed * Time.deltaTime, 0));
		cc.Move (movePos*Time.deltaTime);
		cc.SimpleMove (Physics.gravity);
	
	}
}
