using UnityEngine;
using System.Collections;

public class HelpScreenScript : MonoBehaviour {
	
	void Start()
	{
		try{
		    Destroy(GameObject.Find("ScoreText"));
		}
		catch{
		}
	}
	
	void OnMouseDown(){
		if(this.gameObject.name == "btnHome")
		{
			TransitionManager.Instance.LoadScene("menu",true);
		}
	}
}