using UnityEngine;
using System.Collections;

public class AlyonaScript : MonoBehaviour {

	GameObject player;
	CharControlMoveAlyonaApartment  playerMove;
	float timer;
	Animator anim;
	public GameObject blood;

	public bool alyonaDead;

	// Use this for initialization
	void Start (){

		player = GameObject.FindWithTag ("Rask");
		playerMove = player.GetComponent<CharControlMoveAlyonaApartment> ();
		anim = GetComponent<Animator> ();
		
		anim.SetBool("IsDead", false);
	}
	
	// Update is called once per frame
	void Update () {


		if (playerMove.killing3) {
			timer += Time.deltaTime;
			
			anim.SetBool("IsDead", true);
			alyonaDead = true;


			blood.SetActive(true);
			
			
		}
		
	}
}
