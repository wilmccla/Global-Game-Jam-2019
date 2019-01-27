using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : InteractObject
{
    public override void Interact(GameObject player)
    {
        //Debug.Log(boneCount);
        Destroy(this.gameObject);
    }
}
