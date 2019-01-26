using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class InteractObject : MonoBehaviour,Interactable {

    public string interactText;


    public abstract void Interact(GameObject player);

    public virtual string HoverText()
    {
        return interactText;
    }

    // Use this for initialization

}
