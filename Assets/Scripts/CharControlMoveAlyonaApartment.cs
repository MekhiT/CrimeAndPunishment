using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharControlMoveAlyonaApartment : MonoBehaviour {

	public float MoveSpeed;
	public float RotationSpeed;
	public float v;
	public Vector3 movePos;
	public Vector3 rotation;
	public GameObject door;
	public float time;
	
	public GameObject Liza;

	public bool pickupAxe;
	public bool pickupHat;
	public bool SwitchCamera;
	public bool isTreasure;

	public GameObject axe;
	
	CharacterController cc;
	Animator anim;

	public bool handing;
	public bool holding;
	public bool startText;
	public bool killing;
	public bool killing3;

	public bool ifLiza;



	public GameObject mainCam;
	public GameObject lookCam;

	// Use this for initialization
	void Start () {
		
		cc = GetComponent<CharacterController> ();
		anim = GetComponent<Animator> ();
		
		
		door = GameObject.FindWithTag ("Door");
		axe.SetActive (false);
		
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

			handing = Input.GetKeyDown (KeyCode.E);
			handingItem (handing);

			holding = Input.GetKeyDown (KeyCode.R);
			if(holding){

				axe.SetActive(true);
			}

			killing = Input.GetKeyDown (KeyCode.K);
			killingHer (killing);

			//if(Input.GetKeyDown(KeyCode.E)){

				//handing = true;
			//}


			//if(handing){

				//handingItem();
				//handing = false;


			//}

			
		}
	}

	void killingHer(bool killing2){

		anim.SetBool ("IsKilling", killing2);

		killing3 = killing2;
	}

	void handingItem(bool handing2){

		anim.SetBool ("IsHanding", handing2);

	
	}


	void animate (float ifInput){
		
		bool walking = ifInput != 0f;
		
		anim.SetBool ("IsWalking", walking);

		
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
			
			
				} else if (other.gameObject.tag == "Dialogue") {
						
						startText = true;
				} else if (other.gameObject.tag == "Treasure") {
						isTreasure = true;
						mainCam.camera.active = false;
						lookCam.camera.active = true;
						Liza.SetActive (true);
						ifLiza = true;
				} 

	}
	
	IEnumerator loading(){
		
		yield return new WaitForSeconds(1.0f);
		Application.LoadLevel(Application.loadedLevel +1);
	}
	
	
	
	
}