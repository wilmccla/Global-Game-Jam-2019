using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Owner : MonoBehaviour
{

    public Animator anim;
    public Animator ballAnim;
    public GameObject ball;
    public bool haveBall;
    public int counter = 0;


	// Use this for initialization
	void Start ()
	{
	    anim = GetComponent<Animator>();
	    ballAnim = ball.GetComponent<Animator>();
	}
	
	// Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider Other)
    {
        if (Other.tag == "Player")
        {
            PlayerStuff pStuff = Other.gameObject.GetComponent<PlayerStuff>();
            if (pStuff.hasBall)
            {
                pStuff.hasBall = false;
                haveBall = true;

                if (counter == 0)
                {
                    ballAnim.SetTrigger("Throw1");
                    counter++;
                }

                if (counter == 1)
                {
                    ballAnim.SetTrigger("Throw2");
                    counter++;
                }

                if (counter == 2)
                {
                    ballAnim.SetTrigger("Throw3");
                    counter++;
                }

                if (counter == 3)
                {
                   ballAnim.SetTrigger("Leave");
                }
            }
        }
    }
}
