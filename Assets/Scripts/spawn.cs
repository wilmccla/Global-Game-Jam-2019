using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    private int minWait = 3;
    private int maxWait = 6;
    private bool isSpawning;
    public GameObject Pickup;
    private int seconds; 

    // Use this for initialization
    void Start ()
    {
        isSpawning = false;
   
        InvokeRepeating("SpawnObject", 1, 1);

    }

	// Update is called once per frame
	void Update () {
	    
	}

    void SpawnObject()
    {
        seconds++;
        int number = Random.Range(minWait, maxWait);
        if (seconds >= number)
        {
            GameObject truck = (GameObject)Instantiate(Pickup, transform.position, transform.rotation);
            seconds = 0;
        }
       
        
    }
}
