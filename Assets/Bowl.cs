using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowl : InteractObject {
	public bool eaten = false;
	ParticleSystem particles;

	void Start(){
		particles = GetComponentInChildren<ParticleSystem>();
	}
    public override void Interact(GameObject player)
    {
		if (!eaten){
        	eaten = true;
			interactText = "Empty";
			particles.Play();
						GetComponentInChildren<MeshRenderer>().enabled = false;
			Invoke("hideFood",1);
		}

    }

		void hideFood(){

			particles.Stop();
		}

}
