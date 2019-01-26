using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : InteractObject {

    public string HoverText()
    {
        return "Pick up Ball";
    }

    public override void Interact(GameObject player)
    {
        
    }
}
