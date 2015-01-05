using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextFlowOutsideAlyonaApartment : MonoBehaviour {

	Text text;
	public GameObject tpanel;
	NarratorText nartext;
	float timeElapsed;
	float secondTimer;



	GameObject player;
	GameObject alyona;
	GameObject liza;

	LizaScript lizS;
	CharControlMoveAlyonaApartment playerMove;
	AlyonaScript yonaScript;
	
	void Awake(){
		
		text = GetComponent <Text>();
		nartext = text.GetComponent<NarratorText>();
		text.text = "filler";
		
		timeElapsed = 0.0f;
	}

	void Start(){

		tpanel.SetActive (false);
		player = GameObject.FindWithTag ("Rask");
		playerMove = player.GetComponent<CharControlMoveAlyonaApartment> ();
		alyona = GameObject.FindWithTag ("Alyona");
		//liza = GameObject.FindWithTag ("Liza");
		yonaScript = alyona.GetComponent<AlyonaScript> ();
		//lizS = liza.GetComponent<LizaScript> ();


	}

	void Update(){


		if (playerMove.startText) {
			timeElapsed += Time.deltaTime;

			if(timeElapsed >= 0){

				tpanel.SetActive (true);
				text.text = nartext.aText[0];

				if(timeElapsed >= 3.0f){

					text.text = nartext.rText[11];

					if(timeElapsed >= 11.0f){

						text.text = nartext.aText[1];

						if(timeElapsed >= 15.0f){

							text.text = nartext.rText[16];

							if(timeElapsed >= 20.0f && yonaScript.alyonaDead){

								text.text = nartext.rText[17];

								if(playerMove.isTreasure){

									text.text = nartext.rText[18];
									secondTimer += Time.deltaTime;
									if(secondTimer >= 3.0f){

										text.text = nartext.lText[0];

										if(secondTimer >= 6.0f){

											text.text = nartext.rText[19];

											if(secondTimer>= 14.0f){

												text.text = nartext.nText[1];

												if(secondTimer >= 17.0f){
													StartCoroutine (loading ());

												}
											}
										}

									}
								}
							}
						}

					}

				}

			
			}
				
			
		
		}
	}
	IEnumerator loading(){
		
		yield return new WaitForSeconds(1.0f);
		Application.LoadLevel(Application.loadedLevel +1);
	}

}