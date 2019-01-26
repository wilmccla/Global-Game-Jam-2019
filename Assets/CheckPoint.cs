using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player"){
			col.GetComponent<PlayerController>().SetSpawn(this.gameObject);
		}
	}
}
