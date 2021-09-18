using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMTX : MonoBehaviour {
    float timer;
    Animator animator;

    // Use this for initialization
    void Start () {
        timer = 0;
        animator = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= .5f && timer <= 3.5f)
        {
            animator.SetBool("moveMTX", true);
        }
        /*if (timer > 4.5f)
        {
            animator.SetBool("disappear1", true);
        }
        if (timer > 5.5f && timer <5.51f)
        {
            animator.SetBool("disappear2", true);
        }
        if (timer > 6.5f && timer < 6.51f)
        {
            animator.SetBool("disappear3", true);
        }
        if (timer > 7.5f && timer < 7.51f)
        {
            animator.SetBool("disappear4", true);
        }*/
	}
}
