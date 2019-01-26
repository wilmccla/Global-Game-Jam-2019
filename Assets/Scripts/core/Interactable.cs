using UnityEngine;
using System.Collections;

public interface Interactable
{
    void Interact(GameObject player);

    string HoverText();
}
