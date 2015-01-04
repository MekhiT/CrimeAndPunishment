using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextFlow : MonoBehaviour {

	Text text;
	public GameObject tpanel;
	public bool isControllable;
	NarratorText nartext;
	float timeElapsed;


	void Awake(){


		text = GetComponent <Text>();
		nartext = text.GetComponent<NarratorText>();
		text.text = "filler";

		timeElapsed = 0.0f;


	}

	// Use this for initialization
	void Start () {

		isControllable = false;


	
	}
	
	// Update is called once per frame
	void Update () {

		timeElapsed += Time.deltaTime;

		text.text = nartext.nText[0];

		if (timeElapsed >= 4.0f) {

			text.text = nartext.rText[0];

			if(timeElapsed >=12.0f){

				text.text = nartext.rText[1];
				isControllable = true;


			}


		
		}


	}
}
