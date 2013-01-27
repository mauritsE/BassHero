using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void PlaySound (AudioClip note){

	AudioSource.PlayClipAtPoint(note, transform.position);
	}
}
