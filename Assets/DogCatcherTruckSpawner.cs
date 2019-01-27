using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCatcherTruckSpawner : MonoBehaviour {

	public GameObject truck;
	// Use this for initialization
	void Start () {
		truck.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player"){
			truck.SetActive(true);
		}
	}
}
