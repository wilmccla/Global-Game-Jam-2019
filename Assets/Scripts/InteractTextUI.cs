using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractTextUI : MonoBehaviour {

    private Text interactText;

    public static InteractTextUI instance;

	// Use this for initialization
	void Start () {
        instance = this;
        interactText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetText(string text){
        interactText.text = text;
    }
}
