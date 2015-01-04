using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextFlowOutside2 : MonoBehaviour {

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

		if (timeElapsed >= 3.0f) {
			tpanel.SetActive(true);	
			text.text = nartext.rText[4];

			if(timeElapsed>= 8.0f){

				//splitting rText[6] into two parts
				text.text = "What if… What If man is not really a scoundrel, man in general, I mean, the whole race of mankind - then all the rest is prejudice, simply artificial terrors and there are no barriers and it’s all as it should be? No barriers…..no control...";
				//text.text = nartext.rText[6];
				if(timeElapsed>= 16.0f){

					text.text = "What if I do not exist on the physical plane? What am I, perhaps mere electrical signals, a conglomeration of information on a black mirror, controlled by beings beyond this dimension...What If I’m in a video game?!";

					if(timeElapsed >= 24.0f){

						text.text = nartext.rText[7];

					if(timeElapsed >= 28.0f){

						text.fontSize = 12;
						text.text = nartext.rText[8];
					}
				}
			}
			}
		}

	
	}
}
