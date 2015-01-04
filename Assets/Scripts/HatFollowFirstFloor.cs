using UnityEngine;
using System.Collections;

public class HatFollowFirstFloor : MonoBehaviour {

	public Transform head;

	Vector3 rotationOffSet;
	Vector3 offset;
	Vector3 targetPos;
	CharControlMoveFirstFloor playerMoveScript;
	GameObject player;

	// Use this for initialization
	void Start () {

		//head = GameObject.FindWithTag ("Head").transform;
		//offset = transform.position - head.position;
		player = GameObject.FindWithTag ("Rask");
		playerMoveScript = player.GetComponent<CharControlMoveFirstFloor> ();

	
	}
	
	// Update is called once per frame
	void Update () {

		if (playerMoveScript.pickupHat) {
			//targetPos = head.position + new Vector3(0,1,0);
			transform.position = head.position;
			transform.eulerAngles = head.eulerAngles;
			
		}		
	
	}


}
