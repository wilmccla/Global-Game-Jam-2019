using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowl : InteractObject {
	public bool eaten = false;
    public override void Interact(GameObject player)
    {
		if (!eaten){
        	eaten = true;
			interactText = "Empty";
		}

    }

}
