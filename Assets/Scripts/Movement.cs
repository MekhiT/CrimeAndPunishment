using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float speed = 6f;
	
	
	Vector3 movement;
	Animator anim;
	Rigidbody playerRigidbody;
	int floorMask;
	float camRayLength = 100f;

	bool pressE;
	
	void Awake(){
		
		floorMask = LayerMask.GetMask ("Floor");
		anim = GetComponent <Animator> ();
		playerRigidbody = GetComponent <Rigidbody> ();
		
	}

	void update(){

		pressE = Input.GetKeyDown (KeyCode.E);
	}
	
	void FixedUpdate(){
		
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		
		Move (h, -v);
		
	}
	
	void Move (float h, float v){
		
		movement.Set (h, 0.0f, v);
		
		movement = movement.normalized * speed * Time.deltaTime;
		
		playerRigidbody.MovePosition (transform.position + movement);
		
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "Leave") {

			StartCoroutine(loading ());
		
		} 

	}

	IEnumerator loading(){

		yield return new WaitForSeconds(2.0f);
		Application.LoadLevel(Application.loadedLevel +1);
	}
}
