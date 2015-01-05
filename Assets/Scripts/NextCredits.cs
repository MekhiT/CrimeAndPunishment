using UnityEngine;
using System.Collections;

public class NextCredits : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		StartCoroutine (loading ());
	
	}

	IEnumerator loading(){
		
		yield return new WaitForSeconds(7.0f);
		Application.LoadLevel(Application.loadedLevel +1);
	}
}
