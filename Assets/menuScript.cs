using UnityEngine;
using System.Collections;

public class menuScript : MonoBehaviour {

	
	bool MouseOverPlay = false;
	bool MouseOverHelp = false;
	bool MouseOverQuit = false;
void OnGUI()
{
		//startknop
		//GUILayout.BeginArea(Rect(50,50,50,50));
    GUILayout.BeginVertical();
		GUILayout.Button("Start");
		
    GUILayout.EndVertical();

    if(Event.current.type == EventType.Repaint && 
       GUILayoutUtility.GetLastRect().Contains(Event.current.mousePosition ))
    {
			MouseOverPlay = true;
	}
    else
    {
			MouseOverPlay = false;
    }
		
		//helpknop
		    GUILayout.BeginVertical();
        GUILayout.Button("Help");
    GUILayout.EndVertical();

    if(Event.current.type == EventType.Repaint && 
       GUILayoutUtility.GetLastRect().Contains(Event.current.mousePosition ))
    {
			MouseOverHelp = true;
	}
    else
    {
			MouseOverHelp = false;
    }
		
		//quitknop
		    GUILayout.BeginVertical();
        GUILayout.Button("Quit");
    GUILayout.EndVertical();

    if(Event.current.type == EventType.Repaint && 
       GUILayoutUtility.GetLastRect().Contains(Event.current.mousePosition ))
		{
			MouseOverQuit = true;
	}
    else
    {
			MouseOverQuit = false;
    }
				
}
	
	void OnMouseDown()
	{
		
	}


void Update() 
	{
		Debug.Log(MouseOverPlay);
		if(MouseOverPlay= true& Input.GetMouseButtonDown(0)){

				Application.LoadLevel("gamescreen");
		}
		else if(MouseOverHelp= true& Input.GetMouseButtonDown(0)){
				Application.LoadLevel("helpScreen");
		}
		else if(MouseOverQuit= true& Input.GetMouseButtonDown(0)){
				Application.Quit();
		}
	}
	
}