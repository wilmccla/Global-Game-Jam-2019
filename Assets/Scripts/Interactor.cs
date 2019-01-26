using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour {

	public float interactDistance = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
		void Update () {
			CheckForInteract();
		}

		void CheckForInteract(){

        RaycastHit hit;
        var ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out hit,interactDistance))
        {
            InteractObject interHit = hit.transform.gameObject.GetComponent<InteractObject>();

            if (interHit != null){
                InteractTextUI.instance.SetText(interHit.HoverText());
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interHit.Interact(this.transform.parent.gameObject);
					
                }
            }else{
                InteractTextUI.instance.SetText(" ");
            }
            // Do something with the object that was hit by the raycast.
        }else{
            InteractTextUI.instance.SetText(" ");
        }
    }
}
