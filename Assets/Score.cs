using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public int scoreval = 1000;
	private Light redLight;
	GUIText scoretext;
		void Awake () {
	DontDestroyOnLoad(this);
	}
	// Use this for initialization
	void Start () {
		scoretext = GameObject.Find("ScoreText").GetComponent<GUIText>();
		scoretext.text = "Score: " + scoreval.ToString();
		//GameObject.Find("SparksGreen").GetComponent<GUIText>();
	}

	// Update is called once per frame
	public void scoreUp()
	{
		scoreval +=150;
		scoretext.text = "Score: " + scoreval.ToString();
		
		
	}
	
	public void scoreDown()
	{

		scoreval -=100;
		scoretext.text = "Score: " + scoreval.ToString();
		if( scoreval < 0)
		{
			TransitionManager.Instance.LoadScene("gameOver",true);
		}
	
	}
	public void wrongNote()
	{
	
		scoreval -=5;
		scoretext.text = "Score: " + scoreval.ToString();
		if( scoreval < 0)
		{
			TransitionManager.Instance.LoadScene("gameOver",true);
		}

	}	
	
}
