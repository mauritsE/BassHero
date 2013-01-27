using UnityEngine;
using System.Collections;

public class playsound : MonoBehaviour {
	
	public GameObject firstball;
	public GameObject frontplane;
	public GameObject backplane;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(firstball.transform.position.z < frontplane.transform.position.z && firstball.transform.position.z > backplane.transform.position.z)
		{
		}
	}
}
