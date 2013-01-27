using UnityEngine;
using System.Collections;

public class BloodSplatterCore : MonoBehaviour {

	public GameObject drip;
    private RaycastHit hit;

    public int minNrOfDrops = 10;
    public int maxNrOfDrops = 50;

    public float minScaleOfDrops = 0.5f;
    public float maxScaleOfDrops = 5;

    public int range = 4;

    public float offsetFromHitNormal = 0.1f;

    //public float TimeToLiveDrop = 3;

    private Transform myTransform;

    void Awake () 
    {
        myTransform = transform;

        int cnt = 0;
        int nrOfDrops = Random.Range(minNrOfDrops, maxNrOfDrops);

        while (cnt <= nrOfDrops)
        {            
            Vector3 fwd = transform.TransformDirection (Random.onUnitSphere);

            if (Physics.Raycast(transform.position, fwd, out hit, range))
            {
                if (hit.transform.tag != "Player" && hit.transform.tag != "Enemy") //no decals on moving objects, because they will stay at fixed location when objects move
                {
                    cnt++;
                    //Debug.Log("hit " + hit.transform.name);
                    GameObject splatter = Instantiate(drip, hit.point + (hit.normal * offsetFromHitNormal), Quaternion.FromToRotation(Vector3.up, hit.normal)) as GameObject;

                    float scaler = Random.Range(minScaleOfDrops, maxScaleOfDrops);
                    splatter.transform.localScale = new Vector3(
                        splatter.transform.localScale.x * scaler,
                        splatter.transform.localScale.y,
                        splatter.transform.localScale.z * scaler);

                    int rater = Random.Range(0, 359);
                    splatter.transform.RotateAround(hit.point, hit.normal, rater);

                    splatter.transform.parent = myTransform;

                    //Destroy(splatter, TimeToLiveDrop); //decay takes care of that
                }
            }
        }
	}

   
}
