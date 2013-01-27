using UnityEngine;
using System.Collections;
using System.Xml;

public class XMLLoader : MonoBehaviour {
	WWW www = new WWW("http://elzingam.mctantwerpen.be/teenage_bottlerocket_skate_or_die.xml");
	
	// Use this for initialization
	void Start () {
			XmlDocument xmlDoc = new XmlDocument();
	xmlDoc.LoadXml(www.data);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
