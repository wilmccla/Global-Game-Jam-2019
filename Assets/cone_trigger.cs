using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cone_trigger : MonoBehaviour
{

    public GameObject spawnPoint;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) //This controls what happens when the player enters the trigger box.
    {
        if (other.tag == "Player"
        ) //The player will have a tag that will allow the trigger box to recognize that is the player
        {
            //This is where the code for when the player enters the trigger box. 
            Debug.Log("Player has entered the trigger box");
            other.GetComponent<PlayerController>().Respawn();
        }

        Debug.Log("Object Entered the Trigger");
    }

    public void OnTriggerStay(Collider other) //This controls what happens when the player stays in the trigger box.
    {
        Debug.Log("Object is in the trigger box");
        transform.position = spawnPoint.transform.position;
        transform.rotation = spawnPoint.transform.rotation;
    }

    private void OnTriggerExit(Collider other) // This controla what happens when the player leaves the trigger box.
    {
        Debug.Log("Object has exited the trigger");
    }

    public void SetSpawn(GameObject point)
    {
        spawnPoint = point;


    }
}

