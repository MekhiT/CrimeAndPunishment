using UnityEngine;
using System.Collections;

public class Axe : MonoBehaviour {

	public Transform hand;

	Vector3 rotationOffSet;
	Vector3 targetPos;
	CharControlMoveFirstFloor playerMoveScript;
	GameObject player;



	// Use this for initialization
	void Start () {

		hand = GameObject.FindWithTag ("Hand").transform;
		rotationOffSet = new Vector3 (0, 260, 0);
		player = GameObject.FindWithTag ("Rask");
		playerMoveScript = player.GetComponent<CharControlMoveFirstFloor> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (playerMoveScript.pickupAxe) {
				targetPos = hand.position;
				transform.position = targetPos;
				transform.eulerAngles = hand.eulerAngles + rotationOffSet;
				
		}		

	}
}
