using UnityEngine;
using System.Collections;

public class CreediteMuse : MonoBehaviour {

	public AudioClip coolio;
	public Animator anim;
	void Awake(){

		DontDestroyOnLoad (transform.gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(anim.IsInTransition(0))
	{
		audio.clip = coolio;
		audio.Play();
		audio.loop = true;
		}
	}
}
