using UnityEngine;
using System.Collections;

public class HatFollowElsewhere : MonoBehaviour {
	
	public Transform head;
	
	Vector3 rotationOffSet;
	Vector3 offset;
	Vector3 targetPos;

	
	// Use this for initialization
	void Start () {
		
		head = GameObject.FindWithTag ("Head").transform;
		offset = transform.position - head.position;

		
		
	}
	
	// Update is called once per frame
	void Update () {
		

			targetPos = head.position + offset;
			transform.position = head.position;
			transform.eulerAngles = head.eulerAngles;
			
				
		
	}
	
	
}
