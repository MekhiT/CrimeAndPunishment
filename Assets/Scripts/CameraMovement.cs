using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float offset;
	public Transform player;
	public float smoothing = 5.0f;
	public Vector3 targetPos;

	float x;
	float y;
	float z;


	// Use this for initialization
	void Start () {

		player = GameObject.FindWithTag ("Rask").transform;
		x = transform.position.x;
		y = transform.position.y;
		z = transform.position.z;

		offset = z - player.position.z;

	
	}
	
	// Update is called once per frame
	void Update () {

		float playerZ = player.position.z;

		targetPos = new Vector3 (x, y, offset + playerZ);
		transform.position = Vector3.Lerp (transform.position, targetPos, smoothing * Time.deltaTime);




	
	}
}
