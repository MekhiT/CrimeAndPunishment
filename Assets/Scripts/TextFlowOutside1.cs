using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextFlowOutside1 : MonoBehaviour {

	Text text;
	public GameObject tpanel;
	NarratorText nartext;
	float timeElapsed;

	void Awake (){

		text = GetComponent <Text>();
		nartext = text.GetComponent<NarratorText>();
		text.text = "filler";
		
		timeElapsed = 0.0f;

	}
	// Use this for initialization
	void Start () {

		tpanel.SetActive (false);


	
	}
	
	// Update is called once per frame
	void Update () {

		timeElapsed += Time.deltaTime;
		if (timeElapsed >= 2.0f) {
			
			tpanel.SetActive(true);
			text.text = nartext.rText[2];
			
			if(timeElapsed >=12.0f){
				
				text.text = nartext.rText[3];

				if(timeElapsed >= 16.0f){

					text.text = nartext.rText[5];
				}
				
			}
		}
	}
}
