using UnityEngine;
using System.Collections;

public class ballmove : MonoBehaviour {
	public float speed = 50.0f;

	GameObject frontplane;
	GameObject backplane;
	public float freqlow;
	public float freqhigh;
	public float freq;
	public GameObject ball;
	Score score;
	// Use this for initialization
	void Start () {
		frontplane = GameObject.Find("plane front");
		backplane = GameObject.Find("plane back");
		score = GameObject.Find("ScoreText").GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
	//serialRotation serialdata = GameObject.GetComponent<serialRotation>();

	//frequency = GameObject.Find("SerialDataReceiver").GetComponent<serialRotation>.Method("Getfreqval");

		transform.Translate(new Vector3(0,0,- speed) * Time.deltaTime);
		if(transform.position.z < frontplane.transform.position.z && transform.position.z > backplane.transform.position.z)
		{
			
			
		if(freq > freqlow && freq < freqhigh) 
			{
				//noot spelen
				Destroy(ball);
				score.scoreUp();
				Debug.Log("held");
			}
		else if (freq > 25 && freq < freqlow || freq > freqhigh)
			{
				score.wrongNote();
				//score - 100
				//Debug.Log("you suck!");
			}
		}
		else if (transform.position.z < backplane.transform.position.z - 10) 
		{
			
				score.scoreDown();
			Destroy(ball);
			//Debug.Log("gemist");
		}
	}
	
	public void fillInFreq(float incomingFreq)
	{
		freq = incomingFreq;
		
	}
}
