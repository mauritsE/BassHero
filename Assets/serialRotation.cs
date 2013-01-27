using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class serialRotation : MonoBehaviour {

	SerialPort stream; 
	//Set the port (com4) and the baud rate (9600, is standard on most devices)
	public Light lampB0;
	public Light lampE0;
	public Light lampA0;
	public Light lampD0;
	public Light lampG0;
	 public float delay = 2.0f;
	public static float freqvalue;
	bool usingCom;
	//bool noteplayed;
	public AudioClip Bsound;
	public AudioClip Esound;
	public AudioClip Asound;
	public AudioClip Dsound;
	public AudioClip Gsound;
	
	void Start () {
		try{
		stream = new SerialPort("COM8", 115200);
		stream.ReadTimeout=50;
		stream.Open();
			stream.ReceivedBytesThreshold = 8;
			usingCom=true;
		}
		catch{
			usingCom=false;
		}
		
		lampB0= (Light) GameObject.Find("SpotlightB").GetComponent<Light>();
		lampE0 = (Light) GameObject.Find("SpotlightE").GetComponent<Light>();
		lampA0= (Light) GameObject.Find("SpotlightA").GetComponent<Light>();
		lampD0 = (Light) GameObject.Find("SpotlightD").GetComponent<Light>();
		lampG0= (Light) GameObject.Find("SpotlightG").GetComponent<Light>();
		
		//StartCoroutine(MyWaitFunction (1.0f));
       // StartCoroutine(MyWaitFunction (2.0f));
	}

	// Update is called once per frame
	
	
	public float Getfreqval() 
	{
			string valuetext = stream.ReadLine(); //Read the information
		freqvalue = System.Convert.ToSingle(valuetext);
		
				return freqvalue;
		
		}
	
	
	  private static void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
    {
        SerialPort sp = (SerialPort)sender;
        string indata = sp.ReadExisting();
		Debug.Log(indata);
		Debug.Log("test");
		//freqvalue = System.Convert.ToSingle(indata);
    }
	
	
	
	public float frequencyValueKeyboard() 
	{
		if(Input.GetButtonDown("Fire1")){
			freqvalue = 258000f;
				return freqvalue;
			}	
			else if(Input.GetButtonDown("Fire2"))
			{
				freqvalue = 388000f;
			return freqvalue;
			}
			else if(Input.GetButtonDown("Fire3"))
			{
				freqvalue = 291000f;
			return freqvalue;
			}
			else if(Input.GetButtonDown("Jump"))
			{
				freqvalue = 217000;
			return freqvalue;
			}
			else if(Input.GetButtonDown("gbutton"))
			{
				freqvalue = 163325;
				return freqvalue;
			}
			else
			{	
				//Debug.Log(freqvalue);
				freqvalue = 0.0f;
				return freqvalue;
			}
	}
	
	
	void Update () 
	{
		try
		{
				freqvalue = Getfreqval();
		}
		catch
		{
			freqvalue = frequencyValueKeyboard();
		}
		if(freqvalue > 25) {
			//Debug.Log(freqvalue);

	//if(noteplayed ==false)
	//	{
		
		if ( freqvalue >256000 && freqvalue < 260000) {
			lampB0.enabled = true;
			lampE0.enabled = false;
			lampA0.enabled = false;
			lampD0.enabled = false;
			lampG0.enabled = false;
		//	noteplayed=true;
			//MyWaitFunction(2f);
		//	lampB0.enabled = false;
				if(GameObject.Find("One shot audio")){
					Destroy(GameObject.Find ("One shot audio"));}
				
			
			GameObject.Find("SoundPlayer").GetComponent<Sound>().PlaySound(Bsound);
		}
		else if(freqvalue >386000 && freqvalue < 390000){
			lampB0.enabled=false;
			lampE0.enabled=true;
			lampA0.enabled = false;
			lampD0.enabled = false;
			lampG0.enabled = false;
		//	noteplayed=true;
		//	MyWaitFunction(2f);
//lampE0.enabled = false;
				if(GameObject.Find("One shot audio")){
					Destroy(GameObject.Find ("One shot audio"));}
				
				
				GameObject.Find("SoundPlayer").GetComponent<Sound>().PlaySound(Esound);
		}
		else if(freqvalue >289000 && freqvalue < 293000){
			lampB0.enabled=false;
			lampE0.enabled=false;
			lampA0.enabled = true;
			lampD0.enabled = false;
			lampG0.enabled = false;
		//	noteplayed=true;
			//MyWaitFunction(2f);
			//lampA0.enabled = false;
				if(GameObject.Find("One shot audio")){
					Destroy(GameObject.Find ("One shot audio"));}
				
				
				GameObject.Find("SoundPlayer").GetComponent<Sound>().PlaySound(Asound);
			}
		else if(freqvalue >215000 && freqvalue < 219000){
			lampB0.enabled=false;
			lampE0.enabled=false;
			lampA0.enabled = false;
			lampD0.enabled = true;
			lampG0.enabled = false;
		//	noteplayed=true;
				if(GameObject.Find("One shot audio")){
					Destroy(GameObject.Find ("One shot audio"));}
				
				
				GameObject.Find("SoundPlayer").GetComponent<Sound>().PlaySound(Dsound);
		}
		else if(freqvalue >161000 && freqvalue < 165000){
			lampB0.enabled=false;
			lampE0.enabled=false;
			lampA0.enabled = false;
			lampD0.enabled = false;
			lampG0.enabled = true;
	//		noteplayed=true;}
				
				
				if(GameObject.Find("One shot audio")){
					Destroy(GameObject.Find ("One shot audio"));}
				
				GameObject.Find("SoundPlayer").GetComponent<Sound>().PlaySound(Gsound);
		}
			else if(freqvalue== 0){
				lampB0.enabled=false;
			lampE0.enabled=false;
			lampA0.enabled = false;
			lampD0.enabled = false;
			lampG0.enabled = false;
			}
		
	//}
		if(usingCom==true){
			stream.BaseStream.Flush();
			}//Clear the serial information so we assure we get new information.
		}
		try{
		//GameObject.Find("balB0").GetComponent<ballmove>().fillInFreq(freqvalue);
		GameObject.Find("balB(Clone)").GetComponent<ballmove>().fillInFreq(freqvalue);
		}
		catch { //start countdown
		}
		//gameObject.GetComponent.<ballmove>().fillInFreq(freqvalue);
		//GameObject.FindGameObjectsWithTag("noot").GetComponent<ballmove>().fillInFreq(freqvalue);
	}	
	
		void disable(Light[] lamps){
		for ( int i = 0; i<lamps.Length ;i++){
			lamps[i].enabled=false;
		}
	}
	  IEnumerator MyWaitFunction (float delay) {

		if(delay > 0)
			delay -= Time.deltaTime;
		
		if (delay <=0)
			Debug.Log("2tellenwachten");
		
		     yield return new WaitForSeconds(delay);
	//	Debug.Log("2tellenwachten" +
	//		"");
        }
    
}