using UnityEngine;
using System.Collections;

public class JacketFollow : MonoBehaviour {

	Vector3 JacketOffset;
	public Vector3 targetPos;
	public Transform playerTrans;
	Vector3 playerRotation;
	float jacketRotateSpeed;




	GameObject player;
	CharControlMove playerMove;


	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Rask");
		playerMove = player.GetComponent<CharControlMove> ();

		playerTrans = GameObject.FindWithTag ("Rask").transform;
		JacketOffset = transform.position - playerTrans.position;
	
	}
	
	// Update is called once per frame
	void Update () {


		targetPos = playerTrans.position + JacketOffset;
		transform.position = targetPos;

		transform.rotation = player.transform.rotation;



	
	}
}
