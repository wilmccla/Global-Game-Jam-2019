﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilingCabinet : InteractObject {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Interact(GameObject player)
    {
        GetComponent<Animator>().SetTrigger("Open");
    }
}
