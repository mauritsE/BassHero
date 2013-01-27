using UnityEngine; 
using System.Collections; 

public class timer : MonoBehaviour { 
    IEnumerator Start () {
        yield return StartCoroutine(MyWaitFunction (1.0f));
        print ("1");
        yield return StartCoroutine(MyWaitFunction (2.0f));
        print ("2");
    }

    IEnumerator MyWaitFunction (float delay) {
        float timer = Time.time + delay;
        while (Time.time < timer) {
            yield return null;
			Destroy(this);
        }
    }
}