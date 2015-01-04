using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadLevel (){

		StartCoroutine (loading ());
	}

	IEnumerator loading(){
		
		yield return new WaitForSeconds(2.0f);
		Application.LoadLevel(Application.loadedLevel +1);
	}
}
