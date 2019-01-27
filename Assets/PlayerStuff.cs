using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStuff : MonoBehaviour {

public static PlayerStuff instance;
    public int boneCount = 0;

	public bool hasBall;
	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
