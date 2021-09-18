using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFolate : MonoBehaviour {
    float timer;
    Animator animator;
    public GameObject DHF;
	// Use this for initialization
	void Start () {
        timer = 0;
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= 2.7f)
        {
            animator.SetBool("moveFolate", true);
        }
        if (timer > 4.5f)
        {
            animator.SetBool("disappear1", true);
        }

        //Spawns DHF
        /*if (timer >= 4.0f)
        {
            DHF.SetActive(true);
        }*/
	}
}
// -18.79941 13.86122 75.04892