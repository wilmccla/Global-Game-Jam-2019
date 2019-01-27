using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : InteractObject
{
    private int _bones;
    public override void Interact(GameObject player)
    {
        _bones++;
        Debug.Log(_bones);
        Destroy(this.gameObject);
    }
}
