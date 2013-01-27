using UnityEngine;
using System.Collections;

public class BloodSplatDecay : MonoBehaviour {

    float tmrDecay;

    public float decayTime;

    public float notVisibleTimeInBeginning;

    float newAValue = 0;

	// Use this for initialization
	void Start () {
        //if (transform.GetComponent<Renderer>()) //initially, set alpha to 0 so not visible
        //{
        //    renderer.material.color = new Color(
        //        renderer.material.color.r,
        //        renderer.material.color.g,
        //        renderer.material.color.b,
        //        0);
        //}	
	}

    void Update()
    {
        tmrDecay += Time.deltaTime;


        if (tmrDecay < notVisibleTimeInBeginning) //not visible
        {
            newAValue = 0;
        }
        else //fade out
        {
            newAValue = 1 - tmrDecay / decayTime;
        }

        //adjust alpha
        if (transform.GetComponent<Renderer>())
        {            
            renderer.material.color = new Color(
                renderer.material.color.r,
                renderer.material.color.g,
                renderer.material.color.b,
                newAValue);
        }
        else
        {
            tmrDecay = decayTime; //so will be destroyed
        }

        //destroy when no more needed
        if (tmrDecay >= decayTime)
        {
            Destroy(gameObject);
        }
    }
}
