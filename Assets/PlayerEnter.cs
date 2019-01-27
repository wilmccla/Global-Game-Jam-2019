using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class PlayerEnter : MonoBehaviour
{

    public GameObject dogCatcher;

	// Use this for initialization
	void Start () {
		dogCatcher.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            dogCatcher.SetActive(true);
        }
    }
}
