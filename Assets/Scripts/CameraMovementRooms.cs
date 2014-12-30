using UnityEngine;
using System.Collections;

public class CameraMovementRooms : MonoBehaviour {

	public Vector3 offset;
	public float smoothing = 5.0f;
	Vector3 targetPos;

	Transform player;

	// Use this for initialization
	void Start () {

		player = GameObject.FindWithTag ("Rask").transform;
		offset = transform.position - player.position;

	
	}
	
	// Update is called once per frame
	void Update () {

		targetPos = player.position + offset;
		transform.position = Vector3.Lerp (transform.position, targetPos, smoothing * Time.deltaTime);



	
	}
}
