using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public Transform canvas;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        canvas.gameObject.SetActive(false);
    }
    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (canvas.gameObject.activeInHierarchy == false)
            {
                StartCoroutine(Slide());
            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

    IEnumerator Slide()
    {
        canvas.gameObject.SetActive(true);
        
        anim.Play("MenuSlide", 0, 1f);
        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
    }
}