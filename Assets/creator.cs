using UnityEngine;
using System.Collections;

public class creator : MonoBehaviour {
public GameObject thePrefab;
public GameObject spawnpoint;
	public float freqlow;
	public float freqhigh;
	public float myTimer = 0.5f;
	public float timerValue;
	public int counter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(myTimer >0){
	myTimer -=Time.deltaTime;
	}
	if(myTimer <=0) {
			counter ++;
			GameObject instance = (GameObject)Instantiate(thePrefab, transform.position, transform.rotation);
	instance.AddComponent("ballmove");
	//instance.tag = "noot";
	instance.GetComponent<ballmove>().freqlow = freqlow;
	instance.GetComponent<ballmove>().freqhigh = freqhigh;
	instance.GetComponent<ballmove>().ball = instance;
			//waardes toekennen aan klonen
	myTimer = timerValue;
	if(counter >= 8)
			this.enabled = false;
//Debug.Log(counter);
	}

	
}
	
}
