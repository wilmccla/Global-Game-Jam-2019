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

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("The Truck Entered");
        if (other.gameObject.tag == "truck")
        {
           Debug.Log("The Truck not destroyed");
           Destroy(other.gameObject);
        }
    }
    void OnTriggerExit (Collider other)
    {
        Debug.Log("The truck exited");
        if (other.gameObject.tag == "truck")
        {
            Debug.Log("The truck destroyed");
            Destroy(other.gameObject);
        }
    }
}
