using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insertMTX : MonoBehaviour {

    float timer;
    Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= 3.4f)
        {
            animator.SetBool("insertMTX", true);
        }
	}
}
