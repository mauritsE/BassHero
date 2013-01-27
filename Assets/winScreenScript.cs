using UnityEngine;
using System.Collections;

public class winScreenScript : MonoBehaviour {
	GUIText scoretext;
	GUIText newscoretext;
	// Use this for initialization

	void Start () {
		try{
			scoretext = GameObject.Find("ScoreText").GetComponent<GUIText>();
		newscoretext = GameObject.Find("txtScore").GetComponent<GUIText>();
		newscoretext.text = newscoretext.text+ " " + scoretext.text;
		Destroy(GameObject.Find("ScoreText"));
			
		}
		catch{
			scoretext.text = "  ";
			newscoretext = GameObject.Find("txtScore").GetComponent<GUIText>();
		newscoretext.text = newscoretext.text+ ": " + scoretext.text;
		Destroy(GameObject.Find("ScoreText"));
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
