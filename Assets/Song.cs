using UnityEngine;
using System.Collections;

public class Song : MonoBehaviour {
	
		int loopcounter;
	creator spawnB;
	creator spawnE;
	creator spawnA;
	creator spawnD;
	creator spawnG;
	int i;
	bool firstrun;
		public float myTimer = 1000.0f;
	public float timerValue = 1000.0f;
	void Start(){
		i = 0;
	spawnB = GameObject.Find("spawnB").GetComponent<creator>();
	spawnE= GameObject.Find("spawnE").GetComponent<creator>();
	spawnA = GameObject.Find("spawnA").GetComponent<creator>();
	spawnD= GameObject.Find("spawnD").GetComponent<creator>();
	spawnG= GameObject.Find("spawnG").GetComponent<creator>();
	firstrun = true;
	loopcounter= 0;
		
	}
	
	void Update()
	{
		if(loopcounter >=0 && loopcounter <5)
		{
			Verse();
		}
		else if(loopcounter==5)
		{
						PreChorus();
		}
		else if(loopcounter >=6 && loopcounter <8)
		{
			Chorus();
		}
		else if ( loopcounter == 8 )
		{
			PreBridge();
		}
		else if (loopcounter > 8 && loopcounter < 11)
		{
			Bridge();
		}
		else if ( loopcounter == 11)
		{
			PostBridge();
		}
		else if ( loopcounter >=12 && loopcounter < 17)
		{
			Verse();
		}
		else if ( loopcounter == 17)
		{
			PreChorus();
		}
		else if ( loopcounter>=18 && loopcounter <= 24)
		{
			Chorus();
		}
		else if( loopcounter > 24){
			if(myTimer >0){
			myTimer -=Time.deltaTime;
				Debug.Log("winScreen");
			}
			if(myTimer <=0) {
				TransitionManager.Instance.LoadScene("winScreen",true);
				myTimer = timerValue;
			}
		}
		Debug.Log(myTimer);
	}
	void SongOrder()
	{ 
		/*2 x verseS
		3 x verse 
		1 x prechorus
		2 x chorus
		1 x prebridge
		1 x bridge
		2 x verse
		3 x verse
		1 x prechorus
		2 x chorus
		4 x chorus 
		1 x E */
	
		
	}
	
	void setCounters()
	{
		spawnB.counter = 0;
		spawnE.counter = 0;
		spawnA.counter = 0;
		spawnD.counter = 0;
		spawnG.counter = 0;
	}
	void Verse()
	{

		spawnA.enabled = true;
		if(spawnA.counter == 16)
			{
				spawnA.enabled = false;
				
			}	
		if(spawnA.enabled == false)
			{
				spawnD.enabled = true;
				if(spawnD.counter == 8)
					{
						spawnD.enabled = false;
					}	
				if(spawnD.enabled == false)
					{
						spawnG.enabled = true;
						if(spawnG.counter == 8)
							{
								spawnG.enabled = false;
								setCounters();
								loopcounter++ ;
							}
					}
			}
		
		
	}
	
	void Chorus() 
	{
		if(firstrun == true){
			spawnA.enabled = true;
		if(spawnA.counter == 8)
			{
				spawnA.enabled = false;
				
			}	
		if(spawnA.enabled == false)
			{
				spawnD.enabled = true;
				if(spawnD.counter == 8)
					{
						spawnD.enabled = false;
					}	
				if(spawnD.enabled == false)
					{
						spawnG.enabled = true;
						if(spawnG.counter == 8)
							{
								spawnG.enabled = false;
								
								setCounters();
								firstrun= false;
								
							}
					}
			}
		}
		else
		{
			ChorusPt2();
		}
	} 
	
	void ChorusPt2()
	{
		spawnA.enabled = true;
				if(spawnA.counter == 4)
					{
						spawnA.enabled = false;
					}	
				if(spawnA.enabled == false)
					{
						spawnD.enabled = true;
						if(spawnD.counter == 4)
							{
								spawnD.enabled = false;

								setCounters();
								firstrun= true;
						loopcounter++;
							}
					}
	}
	void PreChorus()
	{
		
			
		spawnE.enabled = true;
		if(spawnE.counter == 8)
			{
				spawnE.enabled = false;
				
			}	
		if(spawnE.enabled == false)
			{
				ChorusPt2();
			}
		
	}
	
	void Bridge()
	{

			spawnE.enabled = true;
		if(spawnE.counter == 8)
			{
				spawnE.enabled = false;
				
			}	
		if(spawnE.enabled == false)
			{
				spawnD.enabled = true;
				if(spawnD.counter == 8)
					{
						spawnD.enabled = false;
					}	
				if(spawnD.enabled == false)
					{
						spawnA.enabled = true;
						if(spawnA.counter == 8)
							{
								spawnA.enabled = false;

								if(spawnA.enabled == false)
								{
									spawnG.enabled = true;
									if(spawnG.counter == 8)
										{
											spawnG.enabled = false;
											
											setCounters();
											loopcounter++;
										}
								}
							}
					}
			}
		
	}
	
	void PreBridge()
	{
		spawnA.enabled = true;
				if(spawnA.counter == 16)
					{
						spawnA.enabled = false;
						setCounters();
						loopcounter++;
					}	
	}
	
	void PostBridge()
	{
		spawnG.enabled = true;
				if(spawnG.counter == 16)
					{
						spawnG.enabled = false;
						setCounters();
						loopcounter++;
					}	
	}
}
 