using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    private int minWait = 3;
    private int maxWait = 6;
    private bool isSpawning;
    public GameObject Pickup;

    // Use this for initialization
    void Start ()
    {
        isSpawning = false;


    }

	// Update is called once per frame
	void Update () {
	    if (!isSpawning)
	    {
	        float timer = Random.Range(minWait, maxWait);
            Invoke("SpawnObject", timer);
	        isSpawning = true;
	    }
	}

    void SpawnObject()
    {
        GameObject truck = (GameObject)Instantiate(Pickup, transform.position, transform.rotation);
        isSpawning = false;
    }
}
