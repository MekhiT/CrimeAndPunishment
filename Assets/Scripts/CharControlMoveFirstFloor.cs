using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//This Class is used for movement in ALL scenes other than rask's apartment
public class CharControlMoveFirstFloor : MonoBehaviour {

	public float MoveSpeed;
	public float RotationSpeed;
	public float v;
	public Vector3 movePos;
	public Vector3 rotation;
	public GameObject door;
	public float time;

	
	public bool pickupAxe;
	public bool pickupHat;
	public bool SwitchCamera;

	CharacterController cc;
	Animator anim;
	public GameObject mainCam;
	public GameObject lookCam;
	// Use this for initialization
	void Start () {
		
		cc = GetComponent<CharacterController> ();
		anim = GetComponent<Animator> ();
		

		door = GameObject.FindWithTag ("Door");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (true) {
			v = Input.GetAxis ("Vertical");
			movePos = v * transform.TransformDirection (Vector3.forward) * MoveSpeed;
			animate (v);
			//transform.Rotate (new Vector3(0, Input.GetAxis ("Horizontal") * RotationSpeed * Time.deltaTime, 0));
			rotation = new Vector3 (0, Input.GetAxis ("Horizontal") * RotationSpeed * Time.deltaTime, 0);
			transform.Rotate (rotation);
			cc.Move (movePos * Time.deltaTime);
			cc.SimpleMove (Physics.gravity);
			
		}
	}
	
	void animate (float ifInput){
		
		bool walking = ifInput != 0f;
		
		anim.SetBool ("IsWalking", walking);
		
	}

	void animateHat(){

			time += Time.deltaTime;
			anim.SetBool ("IsPuttingHat", true);

		if (time >= 1.0f) {
				
			anim.SetBool ("IsPuttingHat", false);
		}
			
	}
	
	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.tag == "Leave") {
			
						StartCoroutine (loading ());
			} else if (other.gameObject.tag == "Door") {
			
						door.rigidbody.AddForce (-transform.forward * 100f, ForceMode.Force);
			} else if (other.gameObject.tag == "Axe") {
						pickupAxe = true;
			
			} else if (other.gameObject.tag == "Hat") {
						//animateHat();

						pickupHat = true;
			} else if (other.gameObject.tag == "Switch Camera") {

					SwitchCamera = true;

			mainCam.camera.active = false;
			lookCam.camera.active = true;
						
				
		}
		
	}
	
	IEnumerator loading(){
		
		yield return new WaitForSeconds(1.0f);
		Application.LoadLevel(Application.loadedLevel +1);
	}
	
	
	
	
}
