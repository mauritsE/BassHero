using UnityEngine;
using System.Collections;

public class MenuButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		if(this.gameObject.name == "btnHelp")
		{
			TransitionManager.Instance.LoadScene("helpScreen", true);
		}
		else if(this.gameObject.name == "btnQuit")
		{
			Application.Quit();
		}
		else if(this.gameObject.name == "btnStart")
		{
			TransitionManager.Instance.LoadScene("gamescreen",true);
		}
	}
}
