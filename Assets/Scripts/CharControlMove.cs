using UnityEngine;
using System.Collections;


public class CharControlMove : MonoBehaviour {

	public float MoveSpeed;
	public float RotationSpeed;
	public float v;
	public Vector3 movePos;
	public Vector3 rotation;

	CharacterController cc;
	Animator anim;
	// Use this for initialization
	void Start () {

		cc = GetComponent<CharacterController> ();
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		v = Input.GetAxis ("Vertical");
		movePos = v * transform.TransformDirection (Vector3.forward) * MoveSpeed;
		animate (v);
		//transform.Rotate (new Vector3(0, Input.GetAxis ("Horizontal") * RotationSpeed * Time.deltaTime, 0));
		rotation = new Vector3 (0, Input.GetAxis ("Horizontal") * RotationSpeed * Time.deltaTime, 0);
		transform.Rotate (rotation);
		cc.Move (movePos*Time.deltaTime);
		cc.SimpleMove (Physics.gravity);

	
	}

	void animate (float ifInput){

		bool walking = ifInput != 0f;

		anim.SetBool ("IsWalking", walking);

	}


}
