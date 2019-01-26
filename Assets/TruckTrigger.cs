using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TruckTrigger : MonoBehaviour
{
   


    // Use this for initialization
    void Start () {
	   
	}
	
	// Update is called once per frame
	void Update ()
	{
	    
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Truck")
        {
           Destroy(gameObject);
        }
    }
}
