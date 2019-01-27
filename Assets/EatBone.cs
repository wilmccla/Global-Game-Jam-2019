using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatBone : InteractObject
{

    public override void Interact(GameObject player)
    {
        player.GetComponent<PlayerStuff>().boneCount++;
        Destroy(this.gameObject);
    }
}
