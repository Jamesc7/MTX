using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DHFR_Anim : MonoBehaviour {

    // Sets the DHFR to false to hide it

    Animator animator;
    public GameObject appearingMolecule;
    float timer = 0;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (DialogueTrigger.number == 3)
        {

            timer += Time.deltaTime;
            // If less than 2 seconds have passed, the DHFR moves up
            if (timer < 2.0f)
            {
                animator.SetBool("MoveUpDHFR", true);
            }
            // if More than 4 seconds have passed, sets the gameobject to inactive
            if (timer >= 4.0f && timer <= 7.0f)
            {
                appearingMolecule.SetActive(true);
                gameObject.SetActive(false);
            }
        }
	}
}
