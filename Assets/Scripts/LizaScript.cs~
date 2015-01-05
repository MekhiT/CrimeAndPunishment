using UnityEngine;
using System.Collections;

public class LizaScript : MonoBehaviour {

	GameObject player;
	CharControlMoveAlyonaApartment  playerMove;
	float timer;
	Animator anim;
	float secondTimer;
	public bool islizaDead;

	Vector3 targetPos;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Rask");
		playerMove = player.GetComponent<CharControlMoveAlyonaApartment> ();
		anim = GetComponent<Animator> ();
		
		anim.SetBool("LizaDead", false);

	
	}
	
	// Update is called once per frame
	void Update () {

		if(playerMove.ifLiza){
			targetPos =  new Vector3 (-4, 0, -3);
			secondTimer = Time.deltaTime;
			anim.SetBool("LizaWalk", true);
			transform.position = Vector3.Lerp(transform.position, targetPos, 1* Time.deltaTime);

			//if(transform.position == targetPos){

				//anim.SetBool ("LizaWalk",false);

			


		if (playerMove.killing3) {
			timer += Time.deltaTime;
			
			anim.SetBool("LizaDead", true);
			islizaDead = true;
			
			//}
			}
		}

	
	}
}
