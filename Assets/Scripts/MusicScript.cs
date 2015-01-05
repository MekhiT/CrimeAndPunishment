using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class MusicScript : MonoBehaviour {
	
	GameObject player;
	CharControlMoveAlyonaApartment peen;
	public AudioClip gameMuse;
	public Animator anim;
	void Awake(){
			
		DontDestroyOnLoad (transform.gameObject);
	}

	// Use this for initialization
	void Start () {
	
	player = GameObject.FindWithTag("Rask");
	peen = player.GetComponent<CharControlMoveAlyonaApartment>();
	}
	
	// Update is called once per frame
	void Update () {
	audio.clip = gameMuse;
	if(peen.killing3){
	audio.mute = true;
	}
	else{
	audio.Play();
	audio.loop = true;
	}
		}
}
